using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipSpeed = 5;
        int gravity = 10;
        int skor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string text)
        {
            Text = text;
        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox_Bird.Top += gravity;
            pictureBox_Bottom.Left -= pipSpeed;
            picturebox_top.Left -= pipSpeed;
            label1.Text = "SKOR:" + skor;

            if (pictureBox_Bottom.Left < -150)
            {
                pictureBox_Bottom.Left = 800;
                skor++;
            }

            if (picturebox_top.Left < -180)
            {
                picturebox_top.Left = 950;
                skor++;
            }
            if (pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Bottom.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(picturebox_top.Bounds) ||
                pictureBox_Bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) || pictureBox_Bird.Top < -25)
            {
                EndGame();
            }

        }
        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "Game Over!";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }


        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}