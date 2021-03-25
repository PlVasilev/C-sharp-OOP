using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Point
    {
        public double PointX { get; set; }
        public double PointY { get; set; }

        public Point(double pointX, double pointY)
        {
            PointX = pointX;
            PointY = pointY;
        }
    }
}
