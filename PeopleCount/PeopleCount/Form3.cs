using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleCount
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем Form2
            Form1 form1 = new Form1();
            form1.Show(); // Отображаем Form1
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }




        private void LoadMap(string district)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string url = "https://maps.google.com/maps?q=ул.+Кирова+2,+Сайсарский+округ,+Якутск,+Якутия,+Россия&output=embed";

            webBrowser1.Navigate(url);
        }
    }
}
