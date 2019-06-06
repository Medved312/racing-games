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
        {
           
            
            File.WriteAllText("C:\\Users\\user\\Desktop\\save1.txt", textBox1.Text);
            File.AppendAllText("C:\\Users\\user\\Desktop\\save1.txt", "\n" + Convert.ToString(Parametrs.score));
            File.AppendAllText("C:\\Users\\user\\Desktop\\save1.txt", "\n" + Convert.ToString(Parametrs.tyan));
            File.AppendAllText("C:\\Users\\user\\Desktop\\save1.txt", "\n" + Convert.ToString(Parametrs.speed));
        }

        private void Download1_Click(object sender, EventArgs e)
        {
          
            FileStream file = new FileStream("C:\\Users\\user\\Desktop\\save1.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком
    
            string save1 = reader.ReadLine();
            if (textBox2.Text == save1)
            {
                Parametrs.score= Convert.ToInt16(reader.ReadLine());
                Parametrs.tyan = Convert.ToBoolean(reader.ReadLine());
                Parametrs.speed=Convert.ToInt16(reader.ReadLine());
            }
            else
            {
                MessageBox.Show("не правильный пароль");
            }


            reader.Close(); //закрываем поток
            
        }

    }
}
