using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form2 : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string text)
        {
            Text = text;
        }

        void kullanicilar()
        {
            baglanti = new SqlConnection("Server= LAPTOP-44E41IHV; Initial Catalog=flappy_bird; Integrated Security= SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("select * from Skorlar", baglanti);
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sifre_label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicilar();
            // Kullanıcı adı ve şifre kontrol sorgusu
            string kontrolSorgu = "SELECT COUNT(*) FROM Skorlar WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";
            komut = new SqlCommand(kontrolSorgu, baglanti);

            // Parametreler ekleniyor
            komut.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text.Trim());
            komut.Parameters.AddWithValue("@sifre", textBox2.Text.Trim());

            // Veritabanı bağlantısını aç
            baglanti.Open();

            // Kullanıcı adı ve şifre kontrolü
            int kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());
            if (kayitSayisi > 0)
            {
                // Kullanıcı adı ve şifre doğruysa giriş başarılı
                MessageBox.Show("Giriş başarılı. Hoş geldiniz!", "Başarılı");
                // Burada yeni bir form açabilir ya da giriş işlemini tamamlayabilirsiniz
                // Örnek:
                Form1 form1 = new Form1(textBox1.Text);
                form1.Show();
                this.Hide();
            }
            else
            {
                // Kullanıcı adı veya şifre yanlışsa hata mesajı göster
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.", "Giriş Başarısız");
            }

            // Veritabanı bağlantısını kapat
            baglanti.Close();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            kullanicilar();
            // Kullanıcı adı kontrolü
            string kontrolSorgu = "SELECT COUNT(*) FROM Skorlar WHERE kullaniciAdi = @kullaniciAdi";
            komut = new SqlCommand(kontrolSorgu, baglanti);

            // Kullanıcı adı parametresi ekleniyor
            komut.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);

            // Veritabanı bağlantısını aç
            baglanti.Open();

            // Kullanıcı adı kontrolü çalıştırılıyor
            int kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());

            if (kayitSayisi > 0)
            {
                // Kullanıcı adı zaten varsa hata mesajı göster
                MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen farklı bir kullanıcı adı seçin.", "Kayıt Başarısız");
            }
            else
            {
                // Kullanıcı adı mevcut değilse kayıt ekle
                string ekleSorgu = "INSERT INTO Skorlar (kullaniciAdi, sifre,toplananskor) VALUES  ( @kullaniciAdi, @sifre,0)";
                komut = new SqlCommand(ekleSorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);

                komut.ExecuteNonQuery(); // Komutu çalıştır
                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Başarılı");
            }

            // Veritabanı bağlantısını kapat
            baglanti.Close();
        }
    }
}
