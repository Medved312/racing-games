using System;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace игра
{
    public partial class Save : Form
    {
        private string saveFileName = "save.xml";
        private string saveFilePath = "D:/";

        public Save()
        {
            InitializeComponent();
        }

        private void save1_Click(object sender, EventArgs e)
        {
            bool isExist = File.Exists(saveFilePath + saveFileName);
            XmlDocument saveFile = new XmlDocument();
            XmlElement root = null;

            if (isExist)
            {
                saveFile.Load(saveFilePath + saveFileName);
                root = saveFile.DocumentElement;
            }
            else
            {
                root = saveFile.CreateElement("Saves");
            }

            XmlElement saveRecord = saveFile.CreateElement("SaveRecord");

            XmlAttribute loginAttribute = saveFile.CreateAttribute("login");
            XmlAttribute passwordAttribute = saveFile.CreateAttribute("password");

            XmlText loginValue = saveFile.CreateTextNode(loginbox.Text);
            XmlText passwordValue = saveFile.CreateTextNode(passwordbox.Text);

            XmlElement scoreElement = saveFile.CreateElement("Score");
            XmlElement speedElement = saveFile.CreateElement("Speed");
            XmlElement tyanElement = saveFile.CreateElement("Tyan");

            XmlText scoreValue = saveFile.CreateTextNode(Parametrs.score.ToString());
            XmlText speedValue = saveFile.CreateTextNode(Parametrs.speed.ToString());
            XmlText tyanValue = saveFile.CreateTextNode(Parametrs.tyan.ToString());

            loginAttribute.AppendChild(loginValue);
            passwordAttribute.AppendChild(passwordValue);

            if (isExist)
            {
                XmlElement saves = saveFile.DocumentElement;

                foreach (XmlNode save in saves)
                {
                    var login = save.Attributes.GetNamedItem("login").InnerText;
                    var password = save.Attributes.GetNamedItem("password").InnerText;

                    if (login == loginbox.Text && password == passwordbox.Text)
                    {
                        MessageBox.Show("Такое сохрание уже есть");
                        return;
                    }
                }
            };

            scoreElement.AppendChild(scoreValue);
            speedElement.AppendChild(speedValue);
            tyanElement.AppendChild(tyanValue);

            saveRecord.Attributes.Append(loginAttribute);
            saveRecord.Attributes.Append(passwordAttribute);

            saveRecord.AppendChild(scoreElement);
            saveRecord.AppendChild(speedElement);
            saveRecord.AppendChild(tyanElement);

            root.AppendChild(saveRecord);

            if (!isExist)
            {
                saveFile.AppendChild(root);
            }



            saveFile.Save(saveFilePath + saveFileName);


        }

        private void Download1_Click(object sender, EventArgs e)
        {
            bool isExist = File.Exists(saveFilePath + saveFileName);

            if (!isExist)
            {
                MessageBox.Show("Сохранений нет");
                return;
            }

            XmlDocument saveFile = new XmlDocument();
            saveFile.Load(saveFilePath + saveFileName);

            XmlElement saves = saveFile.DocumentElement;

            foreach (XmlNode save in saves)
            {
                var login = save.Attributes.GetNamedItem("login").InnerText;
                var password = save.Attributes.GetNamedItem("password").InnerText;

                if (login == loginbox.Text && password == passwordbox.Text)
                {
                    foreach (XmlNode tag in save)
                    {
                        if (tag.Name == "Score")
                        {
                            Parametrs.score = int.Parse(tag.InnerText);
                        }

                        if (tag.Name == "Speed")
                        {
                            Parametrs.speed = int.Parse(tag.InnerText);
                        }

                        if (tag.Name == "Tyan")
                        {
                            Parametrs.tyan = bool.Parse(tag.InnerText);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Логин или пароль не верные");
                }
            }
        }


    }
}