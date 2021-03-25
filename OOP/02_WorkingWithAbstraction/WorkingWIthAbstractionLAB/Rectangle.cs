using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWIthAbstractionLAB
{
    public class Rectangle
    {
        public Point UpperLeft { get; set; }

        public Point LowerRight { get; set; }
        public Rectangle()
        {

        }

        public Rectangle(Point upperLeft, Point lowerRight)
        {
            UpperLeft = upperLeft;
            LowerRight = lowerRight;
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = point.PointX >= UpperLeft.PointX && point.PointX <= LowerRight.PointX;
            bool isInVertical = point.PointX <= UpperLeft.PointY && point.PointY >= LowerRight.PointY;

            return isInHorizontal && isInVertical;
        }

        public static string info()
        {
            return "This is rectangle!";
        }
    }
}
