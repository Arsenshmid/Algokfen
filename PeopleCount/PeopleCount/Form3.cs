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
            Image mapImage = Image.FromFile("C:\\Users\\apce1\\Desktop\\хакатон\\черновикКарты_прототип3.png");

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
