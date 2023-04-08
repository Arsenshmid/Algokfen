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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем Form2
            Form2 form1 = new Form2();
            form1.Show(); // Отображаем Form1


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet5.счетчики". При необходимости она может быть перемещена или удалена.
            this.счетчикиTableAdapter.Fill(this.arsenDataSet5.счетчики);

        }
    }
}
