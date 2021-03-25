using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLAB
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
          return  Math.PI * Math.Pow(Radius,2);
        }


        public double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
