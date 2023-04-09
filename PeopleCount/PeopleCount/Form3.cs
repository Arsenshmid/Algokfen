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



        private void Form3_Load(object sender, EventArgs e)
        {
            Point[] points = new Point[6];

            // Задаем координаты точек на pictureBox1
            points[0] = new Point(100, 100);
            points[1] = new Point(200, 200);
            points[2] = new Point(250, 250);
            points[3] = new Point(150, 150);
            points[4] = new Point(150, 100);
            points[5] = new Point(400, 100);

            // Добавляем обработчик события нажатия на pictureBox1
            pictureBox1.MouseDown += new MouseEventHandler((s, a) =>
            {
                // Определяем, на какую точку кликнули
                int index = -1;
                for (int i = 0; i < points.Length; i++)
                {
                    if (Math.Abs(points[i].X - a.Location.X) <= 40 && Math.Abs(points[i].Y - a.Location.Y) <= 40)
                    {
                        index = i;
                        break;
                    }
                }

                // Выводим информацию в MessageBox
                if (index != -1)
                {
                    MessageBox.Show($"Прописано: 5\nПо факту: 7\nВыгода: 2000");
                }
            });

            // Добавляем обработчик события отрисовки pictureBox1
            pictureBox1.Paint += new PaintEventHandler((s, a) =>
            {
                // Рисуем желтые точки
                Brush brush = Brushes.Red;
                foreach (Point p in points)
                {
                    a.Graphics.FillEllipse(brush, p.X, p.Y, 40, 40);
                }
            });
        }
    }
}
