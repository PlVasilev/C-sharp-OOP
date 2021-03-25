using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapesLAB
{
    class ProgShapesLABram
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle(4, 6);
            IShape square = new Square(4);
            IShape circle = new Circle(3);
            IEnumerable<IShape> shapes = new List<IShape>()
            {
                rectangle,
                square,
                circle
            };
            // we use the methods of IEnumerable // Hight LVL of ABSTRACTION

            if (shapes is List<IShape> listShapes) // adding in IEnumerable
            {
                listShapes.Add(new Square(6));
            }

            var listShapes1 = shapes as List<IShape>;
            listShapes1?.Add(new Circle(12)); // same as above

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
            }

        }
    }
}
