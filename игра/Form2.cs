using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    public partial class Mag : Form
    {
        public Mag()
        {
            InitializeComponent();
        }

        private void Mag_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Parametrs.score < 100)
            {
                MessageBox.Show("у вас не достаточно кредитов");
            }
            else
            {
                Parametrs.score -= 100;
                Parametrs.speed += 1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Parametrs.score < 1000)
            {
                MessageBox.Show("у вас не достаточно кредитов");
            }
            else
            {
                Parametrs.score -= 1000;
                Parametrs.tyan = true;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.реф;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
