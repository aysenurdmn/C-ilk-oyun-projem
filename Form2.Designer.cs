namespace FlappyBird
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullanici_adi_label = new System.Windows.Forms.Label();
            this.sifre_label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.kayit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kullanici_adi_label
            // 
            this.kullanici_adi_label.AutoSize = true;
            this.kullanici_adi_label.BackColor = System.Drawing.Color.DarkCyan;
            this.kullanici_adi_label.Location = new System.Drawing.Point(296, 167);
            this.kullanici_adi_label.Name = "kullanici_adi_label";
            this.kullanici_adi_label.Size = new System.Drawing.Size(101, 16);
            this.kullanici_adi_label.TabIndex = 1;
            this.kullanici_adi_label.Text = "KULLANICI ADI:";
            this.kullanici_adi_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifre_label2
            // 
            this.sifre_label2.AutoSize = true;
            this.sifre_label2.BackColor = System.Drawing.Color.DarkCyan;
            this.sifre_label2.Location = new System.Drawing.Point(296, 206);
            this.sifre_label2.Name = "sifre_label2";
            this.sifre_label2.Size = new System.Drawing.Size(49, 16);
            this.sifre_label2.TabIndex = 2;
            this.sifre_label2.Text = "ŞİFRE:";
            this.sifre_label2.Click += new System.EventHandler(this.sifre_label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 22);
            this.textBox2.TabIndex = 4;
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.giris_btn.Location = new System.Drawing.Point(299, 279);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(100, 40);
            this.giris_btn.TabIndex = 5;
            this.giris_btn.Text = "GİRİŞ YAP";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayit_btn
            // 
            this.kayit_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.kayit_btn.Location = new System.Drawing.Point(440, 279);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(101, 40);
            this.kayit_btn.TabIndex = 6;
            this.kayit_btn.Text = "KAYIT OL";
            this.kayit_btn.UseVisualStyleBackColor = false;
            this.kayit_btn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 662);
            this.Controls.Add(this.kayit_btn);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sifre_label2);
            this.Controls.Add(this.kullanici_adi_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kullanici_adi_label;
        private System.Windows.Forms.Label sifre_label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Button kayit_btn;
    }
}