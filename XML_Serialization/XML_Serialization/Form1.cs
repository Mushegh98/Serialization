using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML_Serialization
{
    public partial class Form1 : Form
    {
        MySerialize mySerialize = new MySerialize();
        MySerialize myDeSerialize = new MySerialize();
        XmlSerializer serializer = new XmlSerializer(typeof(MySerialize));

        public Form1()
        {
           
            InitializeComponent();
            Age_t.Text = "0";
        }

       //Serialize Click Event
        private void Serialize_Click(object sender, EventArgs e)
        {
            SetValue();
            using(var stream=new FileStream("Serialization.xml",FileMode.Create,FileAccess.Write))
            {
                serializer.Serialize(stream, mySerialize);
                this.Text = "Object Serialization Complete";
            }
        }

        //DeSerialize Click Event
        private void DeSerialize_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            using (var stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read))
            {
                myDeSerialize = serializer.Deserialize(stream) as MySerialize;
                this.Text = "Object Deserialized";
                textBox1.Text += myDeSerialize.FirstName + Environment.NewLine + myDeSerialize.LastName + 
                    Environment.NewLine + myDeSerialize.E_Mail + Environment.NewLine + myDeSerialize.Age
                     + Environment.NewLine + myDeSerialize.Gender + Environment.NewLine + myDeSerialize.Country;
                    
            }
        }

        //Функция для добовление значение который ввел ползователь в свойства нашего класса MySerialize
        private void SetValue()
        {
            mySerialize.FirstName = First_Name_t.Text;
            mySerialize.LastName = Last_Name_t.Text;
            mySerialize.E_Mail = Mail_t.Text;
            mySerialize.Age = Convert.ToInt32(Age_t.Text);
            mySerialize.Gender = Gender_t.Text;
            mySerialize.Country = Country_t.Text;
        }

        //Remove Click Event
        private void Remove_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            Last_Name_t.Text = " ";
            Mail_t.Text = " ";
            Age_t.Text = "0";
            Gender_t.Text = " ";
            Country_t.Text = " ";
            SetValue();
        }
    }
}
