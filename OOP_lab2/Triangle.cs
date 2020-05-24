using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2
{
    class Triangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;

        public Triangle(Point2D _p1, Point2D _p2, Point2D _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }
        
        public Point2D getPoint1()
        {
            return p1;
        }

        public Point2D getPoint2()
        {
            return p2;
        }
        public Point2D getPoint3()
        {
            return p3;
        }

        public void shiftX(double value)
        {
            p1.shiftX(value);
            p2.shiftX(value);
            p3.shiftX(value);
        }

        public void shiftY(double value)
        {
            p1.shiftY(value);
            p2.shiftY(value);
            p3.shiftY(value);
        }

        public double getPerimeter()
        {
            return (
               p1.getDistance(p2) +
               p2.getDistance(p3) +
               p3.getDistance(p1)
               );
        }

        public double getArea()
        {
            return (Math.Sqrt(
                (getPerimeter() / 2 * (getPerimeter() / 2 - p1.getDistance(p2))) +
                (getPerimeter() / 2 * (getPerimeter() / 2 - p2.getDistance(p3))) +
                (getPerimeter() / 2 * (getPerimeter() / 2 - p3.getDistance(p1)))
                       ));
        }
    }
}
