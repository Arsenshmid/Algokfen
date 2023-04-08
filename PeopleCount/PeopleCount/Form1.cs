using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form2 form1 = new Form2();
            form1.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string appName = "PeopleCount";
            string version = "1.0";
            string author = "Algokfen team";
            string description = "Программа для отображения карты города с домами Сайсарского полигона и редактирования таблиц с реальными данными по жителям и потенциальной выгоде.";

            string message = $"Название программы: {appName}\nВерсия: {version}\nАвтор: {author}\n\nОписание: {description}";

            MessageBox.Show(message, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form1 = new Form6();
            form1.Show();
        }
    }
}
