using System; // we should remove unused usings

namespace WorkingWIthAbstractionLAB
{
    class WorkingWIthAbstractionLAB
    {
        static void Main(string[] args)
        {
            //ClassArch test = new ClassArch(6,8);
            //Console.WriteLine(test.numbers1[0]);
            //Console.WriteLine(test.MyProperty);

            // Math is Satic class we use it when there is no need for instances 
            //(when we have only mathods in it) it must have only static methods

            // Rectangle is instance Class when we need instances  - it can have static methods also

            Rectangle rectangleNew = new Rectangle(new Point(3, 6), new Point(8, 4)); // definition whit constructor

            Rectangle rectangle = new Rectangle() // same definition with empty constructor
            {
                UpperLeft = new Point(3, 6),
                LowerRight = new Point(8,4)
            };

            Console.WriteLine(Rectangle.info());// using static methods but it works only with the Class no with the instance

            Console.WriteLine(rectangle.Contains(new Point(1, 5)));
            Console.WriteLine(rectangle.Contains(new Point(5, 4)));
        }
    }
}
