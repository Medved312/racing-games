using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace игра
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void save1_Click(object sender, EventArgs e)
        {   int save1 = 0;
            int save2 = 0;
            int save3 = 0; //доработка
            if 
            File.WriteAllText("C:\\Users\\Arterion\\Desktop\\save1.txt", Convert.ToString(Parametrs.score));
            File.AppendAllText("C:\\Users\\Arterion\\Desktop\\save1.txt", "\n" + Convert.ToString(Parametrs.tyan));
        }
    }
}
