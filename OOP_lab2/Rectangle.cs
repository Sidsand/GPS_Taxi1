using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2
{
    class Rectangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        private Point2D p4;

      

        public Rectangle(Point2D _p1, Point2D _p2, Point2D _p3, Point2D _p4)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
            p4 = _p4;
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
        public Point2D getPoint4()
        {
            return p4;
        }
        public void shiftX(double value)
        {
            p1.shiftX(value);
            p2.shiftX(value);
            p3.shiftX(value); 
            p4.shiftX(value);
        }

        public void shiftY(double value)
        {
            p1.shiftY(value);
            p2.shiftY(value);
            p3.shiftY(value);
            p4.shiftY(value);
        }

        public double getPerimeter()
        {
            return (
                p1.getDistance(p2) +
                p2.getDistance(p3) +
                p3.getDistance(p4) +
                p4.getDistance(p1)
                );

        }

        public double getArea()
        {
            return (p1.getDistance(p2) *
                    p2.getDistance(p3)
                   );
        }
    }
}
