using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;

namespace OOP_lab2
{
    class Generation
    {

        Random random = new Random();

        private Point2D rnd2D(Random random)
        {
            return new Point2D(random.NextDouble() * 400, random.NextDouble() * 350);
        }

        public Triangle genTriangle()
        {

                Point2D p1 = rnd2D(random);
                Point2D p2 = rnd2D(random);
                Point2D p3 = rnd2D(random);

                Triangle triangle = new Triangle(p1, p2, p3);
                return triangle;
        }
        

        public Rectangle genRectangle()
        {
            Point2D p1 = rnd2D(random);
            Point2D p2 = new Point2D(random.NextDouble()*400, p1.getY());
            Point2D p3 = new Point2D(p2.getX(), random.NextDouble()*350);
            Point2D p4 = new Point2D(p1.getX(), p3.getY());
        
            Rectangle rectangle = new Rectangle(p1, p2, p3, p4);

            return rectangle;
        }



        public Rectangle genRectanglez(double a, double b)
        {
            
            Point2D p1 = rnd2D(random);
            Point2D p2 = new Point2D(p1.getX() + b, p1.getY());

            Point2D p3 = new Point2D(p2.getX(), p2.getY() + a);
            Point2D p4 = new Point2D(p1.getX(), p3.getY());

            Rectangle rectz = new Rectangle(p1, p2, p3, p4);

            return rectz;
        }
    }
}
