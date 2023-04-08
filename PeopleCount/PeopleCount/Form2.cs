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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet4.NewTable". При необходимости она может быть перемещена или удалена.
            this.newTableTableAdapter.Fill(this.arsenDataSet4.NewTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet3.NewSaisar". При необходимости она может быть перемещена или удалена.
            this.newSaisarTableAdapter1.Fill(this.arsenDataSet3.NewSaisar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet2.NewSaisar". При необходимости она может быть перемещена или удалена.
            this.newSaisarTableAdapter.Fill(this.arsenDataSet2.NewSaisar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet.saisar". При необходимости она может быть перемещена или удалена.
            //this.saisarTableAdapter.Fill(this.arsenDataSet.saisar);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
