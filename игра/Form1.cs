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
            ram = new Random();
            r1 = ram.Next(4, 15);
            r2 = ram.Next(4, 15);
            r3 = ram.Next(4, 15);
        }

        Random ram;
        int r1;
        int r2;
        int r3;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e) 
        {


            int x = pictureBox1.Location.X;
            pictureBox1.Left = x + Parametrs.speed;
            int x2 = pictureBox2.Location.X;
            pictureBox2.Left = x2 + r1;
            int x3 = pictureBox3.Location.X;
            pictureBox3.Left = x3 + r2;
            int x4 = pictureBox4.Location.X;
            pictureBox4.Left = x4 + r3;

            if (pictureBox1.Left > 377)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                Parametrs.score = Parametrs.score + 100;
                label7.Text = Convert.ToString(Parametrs.score);
            }
            if (pictureBox2.Left > 377)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("вы проиграли");
            }
            if (pictureBox3.Left > 377)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("вы проиграли");

            }
            if (pictureBox4.Left > 377)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("вы проиграли");
            }
        } //движение и награда

        private void timer2_Tick(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            if(pictureBox1.Image == Properties.Resources._2)
            {
                pictureBox1.Image = Properties.Resources._1;
            }
            
            pictureBox2.Image = Properties.Resources._1;
            pictureBox3.Image = Properties.Resources._1;
            pictureBox4.Image = Properties.Resources._1;

        } //шаг 1

        private void timer3_Tick(object sender, EventArgs e) // шаг 2
        {
            PictureBox pb = new PictureBox();
            if (pictureBox1.Image == Properties.Resources._1)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            
            pictureBox2.Image = Properties.Resources._2;
            pictureBox3.Image = Properties.Resources._2;
            pictureBox4.Image = Properties.Resources._2;
        }

        private void timer4_Tick(object sender, EventArgs e) //обновлкение кредитов
        {
            label7.Text = Convert.ToString(Parametrs.score);
        }


        private void button1_Click(object sender, EventArgs e) // старт и проверка скина
        {
            if (Parametrs.tyan == true)
            {
                int H = pictureBox1.Size.Height;
                pictureBox1.Height = 45;
                int W = pictureBox1.Size.Width;
                pictureBox1.Width = 35;
                pictureBox1.Image = Properties.Resources.ezgif_com_reverse;
            }
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            pictureBox1.Left = 42;
            pictureBox2.Left = 42;
            pictureBox3.Left = 42;
            pictureBox4.Left = 42;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ram = new Random();
            r1 = ram.Next(4, 15);
            r2 = ram.Next(4, 15);
            r3 = ram.Next(4, 15);
        } //перезапуск скорости противников 

        private void button2_Click(object sender, EventArgs e)
        {
            Mag mag = new Mag();
            mag.Show();
        } //магаз

        private void button4_Click(object sender, EventArgs e)
        {
            Save save = new Save();
            save.Show();
           
        }//сохранение


    }
}

