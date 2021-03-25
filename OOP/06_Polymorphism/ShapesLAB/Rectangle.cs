using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLAB
{
    public class Rectangle : IShape
    {
 
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double wight , double height)
        {
            Width = wight;
            Height = height;
        }


        public virtual double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
