using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace игра
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            pictureBox1.Left = x + 10;
            int x2 = pictureBox2.Location.X;
            pictureBox2.Left = x + 12;
            int x3 = pictureBox3.Location.X;
            pictureBox3.Left = x + 2;
            int x4 = pictureBox4.Location.X;
            pictureBox4.Left = x + 5;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pictureBox1.Image = Properties.Resources._1;
            pictureBox2.Image = Properties.Resources._1;
            pictureBox3.Image = Properties.Resources._1;
            pictureBox4.Image = Properties.Resources._1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pictureBox1.Image = Properties.Resources._2;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox3.Image = Properties.Resources._2;
            pictureBox4.Image = Properties.Resources._2;
        }
    }
}
