using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2
{
    class Point2D
    {
        
        private double x;
        private double y;

        private double sx;
        private double sy;

        public Point2D(double _x, double _y){
            x = _x;
            y = _y;
        }

        public double getX()
        {
            return x+sx;
        }
        public double getY()
        {
            return sy+y;
        }

        public void shiftX(double value)
        {
            sx = -value;
        }
        public void shiftY(double value)
        {
            sy = -value;
        }

        public double getDistance(Point2D otherPoint)
        {
            return (Math.Sqrt( Math.Pow((x-otherPoint.x),2) + Math.Pow((y-otherPoint.y),2)));
        }

        public string getCoords()
        {
            return getX().ToString("0") + ", " + getY().ToString("0") + "\n";
        }
    }


}
