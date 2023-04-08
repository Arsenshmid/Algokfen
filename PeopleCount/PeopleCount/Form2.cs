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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем Form2
            Form1 form1 = new Form1();
            form1.Show(); // Отображаем Form1
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form1 = new Form4();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form1 = new Form5();
            form1.Show();
        }
    }
}
