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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet13.НоваяТаблица". При необходимости она может быть перемещена или удалена.
            this.новаяТаблицаTableAdapter3.Fill(this.arsenDataSet13.НоваяТаблица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet12.НоваяТаблица". При необходимости она может быть перемещена или удалена.
            this.новаяТаблицаTableAdapter2.Fill(this.arsenDataSet12.НоваяТаблица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet11.НоваяТаблица". При необходимости она может быть перемещена или удалена.
            this.новаяТаблицаTableAdapter1.Fill(this.arsenDataSet11.НоваяТаблица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet10.НоваяТаблица". При необходимости она может быть перемещена или удалена.
            this.новаяТаблицаTableAdapter.Fill(this.arsenDataSet10.НоваяТаблица);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet6.ФактическоеЧислоЖителей". При необходимости она может быть перемещена или удалена.
            this.фактическоеЧислоЖителейTableAdapter.Fill(this.arsenDataSet6.ФактическоеЧислоЖителей);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
