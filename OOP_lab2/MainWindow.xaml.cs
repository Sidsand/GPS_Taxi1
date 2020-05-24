using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace OOP_lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Triangle triangle;
        private Rectangle rectangle;

        private Generation generation = new Generation();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawLine(Point2D begin, Point2D end)
        {
            Line line = new Line();
            line.Stroke = Brushes.Purple;
            line.StrokeThickness = 2;
            line.X1 = begin.getX();
            line.Y1 = begin.getY();
            line.X2 = end.getX();
            line.Y2 = end.getY();
            canvas.Children.Add(line);
        }
        private void drawTriangle(Triangle triangle)
        {
            drawLine(triangle.getPoint1(), triangle.getPoint2());
            drawLine(triangle.getPoint2(), triangle.getPoint3());
            drawLine(triangle.getPoint3(), triangle.getPoint1());
        }
        private void drawRectangle(Rectangle rectangle)
        {
            drawLine(rectangle.getPoint1(), rectangle.getPoint2());
            drawLine(rectangle.getPoint2(), rectangle.getPoint3());
            drawLine(rectangle.getPoint3(), rectangle.getPoint4());
            drawLine(rectangle.getPoint4(), rectangle.getPoint1());
        }
       

       


        private void Треугольник_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            rectangle = null;
            this.triangle = generation.genTriangle();

            drawTriangle(this.triangle);

            textTriangle();
            ОсьX.Value = 0;
            ОсьY.Value = 0;
        }

        private void Прямоугольник_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            triangle = null;
            this.rectangle = generation.genRectangle();

            drawRectangle(this.rectangle);
            textRectangle();
            ОсьX.Value = 0;
            ОсьY.Value = 0;
        }

        private void Квадрат_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            double a = Convert.ToInt32(RectH.Text);
            double b = Convert.ToInt32(RectW.Text);

            triangle = null;
            this.rectangle = generation.genRectanglez(a, b);

            drawRectangle(this.rectangle);
            textRectangle();
            ОсьX.Value = 0;
            ОсьY.Value = 0;
        }

        
        private void textRectangle()
        {
            Stat.Content = ("Координаты вершин: \n"
                 + "                                     Точка 1: " + rectangle.getPoint1().getCoords()
                + "                                     Точка 2: " + rectangle.getPoint2().getCoords()
                + "                                     Точка 3: " + rectangle.getPoint3().getCoords()
                + "                                     Точка 4: " + rectangle.getPoint4().getCoords()
            +   "\n" + "                                     Периметр: " + rectangle.getPerimeter().ToString("0") + "\n"
                + "                                     Площадь: " + rectangle.getArea().ToString("0"));
        }
        private void textTriangle()
        {
            Stat.Content = ("Координаты вершин: \n"
                 + "                                     Точка 1: " + triangle.getPoint1().getCoords()
                 + "                                     Точка 2: " + triangle.getPoint2().getCoords()
                 + "                                     Точка 3: " + triangle.getPoint3().getCoords()
               + "\n" + "                                     Периметр: " + triangle.getPerimeter().ToString("0") + "\n"
                 + "                                     Площадь: " + triangle.getArea().ToString("0"));
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Stat.Content = ("Координаты вершин: \n");
            ОсьX.Value = 0;
            ОсьY.Value = 0;
        }


        private void ОсьX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (rectangle != null)
            {
                rectangle.shiftX(ОсьX.Value);
                canvas.Children.Clear();
                drawRectangle(rectangle);
                textRectangle();

            }
            
            if (triangle != null)
            {
                triangle.shiftX(ОсьX.Value);
                canvas.Children.Clear();
                drawTriangle(triangle);
                textTriangle();
            }
        }

        private void ОсьY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (rectangle != null)
            {
                rectangle.shiftY(ОсьY.Value);
                canvas.Children.Clear();
                drawRectangle(rectangle);
                textRectangle();
            }
       
            
            if (triangle != null)
            {
                triangle.shiftY(ОсьY.Value);
                canvas.Children.Clear();
                drawTriangle(triangle);

                textTriangle();
            }
        }


    }
}
