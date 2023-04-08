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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем Form2
            Form3 form1 = new Form3();
            form1.Show(); // Отображаем Form1
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet6.ФактическоеЧислоЖителей". При необходимости она может быть перемещена или удалена.
            this.фактическоеЧислоЖителейTableAdapter.Fill(this.arsenDataSet6.ФактическоеЧислоЖителей);

        }
    }
}
