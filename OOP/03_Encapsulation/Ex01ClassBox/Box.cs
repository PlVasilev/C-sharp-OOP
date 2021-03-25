using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01ClassBox
{
    public class Box
    {
        private double lenght;
        private double widht;
        private double height;

        private double Lenght
        {
            get { return lenght; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                else
                {
                    lenght = value;
                }
                ;
            }
        }

        private double Widht
        {
            get { return widht; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                else
                {
                    widht = value;
                }
                ;
            }
        }
        private double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                else
                {
                    height = value;
                }
                ;
            }
        }

        public Box(double lenght, double widht, double height)
        {
            Lenght = lenght;
            Widht = widht;
            Height = height;
        }

        public double GetSurfaceArea()
        {
            return lenght * height * 2 + widht * height * 2 + widht * lenght * 2;
        }

        public double GetLateralSurfaceArea()
        {
            return lenght * height * 2 + widht * height * 2;
        }

        public double GetVolume()
        {
            return lenght * height * widht;
        }
    }
}
