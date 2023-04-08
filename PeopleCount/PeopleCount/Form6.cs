using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PeopleCount
{
    public partial class Form6 : Form
    {
        // создаем объект SqlConnection
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PI5CL2S\\SQLEXPRESS;Initial Catalog=arsen;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form1 = new Form5();
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Text_Text = comboBox1.Text;
            int commaIndex = Text_Text.IndexOf(',');
            string numberString = Text_Text.Substring(0, commaIndex).Trim();

            if (int.TryParse(numberString, out int temp_id))
            {
                //MessageBox.Show($"id = {temp_id}");
            }
            else
            {
                //MessageBox.Show("Не удалось получить id.");
            }

            if (temp_id != null)
            {
                // Получаем числовое значение числа жителей из таблицы NewTable по выбранному адресу
                string query1 = $"SELECT [число_жителей] FROM [arsen].[dbo].[NewTable] WHERE [id] = '{temp_id}'";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                int? numResidents2 = (int?)cmd1.ExecuteScalar();
                textBox2.Text = numResidents2?.ToString() ?? "Не найдено";

                // Получаем числовое значение числа жителей из таблицы ФактическоеЧислоЖителей по выбранному адресу
                string query2 = $"SELECT [число_жителей] FROM [arsen].[dbo].[ФактическоеЧислоЖителей] WHERE [id] = '{temp_id}'";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                int? numResidents1 = (int?)cmd2.ExecuteScalar();
                textBox1.Text = numResidents1?.ToString() ?? "Не найдено";

                // Вычисляем разницу между официальным числом жителей и фактическим числом жителей и умножаем на 1000
                int difference = (numResidents2 ?? 0) - (numResidents1 ?? 0);
                int potentialSavings = difference * 1000;

                // Отображаем результат вычисления в textBox3 и выводим сообщение, если число жителей меньше, чем заявлено
                if (difference > 0)
                {
                    textBox3.Text = potentialSavings.ToString();
                    
                }
                else
                {
                    MessageBox.Show($"Число жителей в доме меньше, чем заявлено. Необходимо сократить расходы на данный дом. Разница: {difference} чел.");
                    textBox3.Text = "0";
                }
            }
            else
            {
                textBox1.Text = "Не найдено";
                textBox2.Text = "Не найдено";
            }


        }











        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet9.full_address". При необходимости она может быть перемещена или удалена.
            this.full_addressTableAdapter2.Fill(this.arsenDataSet9.full_address);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet8.full_address". При необходимости она может быть перемещена или удалена.
            this.full_addressTableAdapter1.Fill(this.arsenDataSet8.full_address);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet7.full_address". При необходимости она может быть перемещена или удалена.
            this.full_addressTableAdapter.Fill(this.arsenDataSet7.full_address);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arsenDataSet4.NewTable". При необходимости она может быть перемещена или удалена.
            this.newTableTableAdapter.Fill(this.arsenDataSet4.NewTable);

            // открываем соединение с базой данных
            connection.Open();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            // закрываем соединение с базой данных при закрытии формы
            connection.Close();
        }
    }
}
