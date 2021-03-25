using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;

        public int Width
        {
            get { return width; }
            private set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Width must be minimum 4");
                }
                width = value;
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            private set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Height must be minimum 4");
                }
                height = value;
            }
        }


        public Rectangle(int wight, int height)
        {
            Width = wight;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine(new string('*', Width));
            for (int i = 0; i < Height - 2; i++)
            {
                Console.WriteLine($"*{new string(' ', Width - 2)}*");
            }
            Console.WriteLine(new string('*', Width));
        }
    }
}
