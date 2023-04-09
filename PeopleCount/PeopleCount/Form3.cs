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
            // Загрузить изображение карты в PictureBox
            pictureBox1.Image = Image.FromFile("C:\\Users\\apce1\\Desktop\\хакатон\\черновикКарты_прототип2.png");

            // Добавить метки на карту
            markerPositions.Add(new PointF(100, 200));
            markerPositions.Add(new PointF(300, 400));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Обработчик события нажатия кнопки мыши на PictureBox
            // Определяем, было ли нажатие на метку
            for (int i = 0; i < markerPositions.Count; i++)
            {
                PointF markerPos = markerPositions[i];
                RectangleF markerRect = new RectangleF(markerPos.X - 5, markerPos.Y - 5, 10, 10);

                if (markerRect.Contains(e.Location))
                {
                    isDragging = true;
                    currentMarkerPos = markerPos;
                    return;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Обработчик события перемещения мыши на PictureBox
            // Перемещаем выбранную метку, если она есть
            if (isDragging)
            {
                currentMarkerPos.X = e.X;
                currentMarkerPos.Y = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Обработчик события отпускания кнопки мыши на PictureBox
            // Заканчиваем перемещение метки
            isDragging = false;
            currentMarkerPos = PointF.Empty;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Обработчик события перерисовки PictureBox
            // Рисуем метки на картинке
            Graphics g = e.Graphics;
            foreach (PointF markerPos in markerPositions)
            {
                g.FillEllipse(Brushes.Red, markerPos.X - 5, markerPos.Y - 5, 10, 10);
            }
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
            // webBrowser1.Navigate("https://www.openstreetmap.org");



            //// Создайте объект карты SharpMap
            //SharpMap.Map myMap = new SharpMap.Map(pictureBox1.Size);

            //// Создайте источник данных для карты
            //SharpMap.Data.Providers.ShapeFile myDataSource = new SharpMap.Data.Providers.ShapeFile(@"C:\Users\apce1\Desktop\хакатон\PeopleCount\map.png");

            //// Добавьте источник данных на карту
            //myMap.Layers.Add(new SharpMap.Layers.VectorLayer("My layer", myDataSource));

            //// Установите начальное положение карты и масштаб
            //myMap.ZoomToExtents();

            //// Отобразите карту в PictureBox
            //pictureBox1.Image = myMap.GetMap();




            // Создание изображения карты
            Image mapImage = Image.FromFile("C:\\Users\\apce1\\Desktop\\хакатон\\черновикКарты_прототип2.png");

            // Создание объекта Graphics для рисования на картинке
            Graphics g = Graphics.FromImage(mapImage);

            // Рисование метки на изображении
            SolidBrush brush = new SolidBrush(Color.Red); // выбор цвета метки
            int x = 100; // координата x метки на карте
            int y = 200; // координата y метки на карте
            int size = 10; // размер метки
            g.FillEllipse(brush, x - size / 2, y - size / 2, size, size); // рисование круглой метки в точке (x, y)

            // Отображение изображения на PictureBox
            pictureBox1.Image = mapImage;
        }
        private List<PointF> markerPositions = new List<PointF>();
        private bool isDragging = false;
        private PointF currentMarkerPos = PointF.Empty;

     

       
    }
}
