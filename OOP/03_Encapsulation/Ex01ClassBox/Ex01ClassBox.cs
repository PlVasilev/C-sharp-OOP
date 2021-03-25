using System;

namespace Ex01ClassBox
{
    class Ex01ClassBox
    {
        static void Main(string[] args)
        {
            try
            {
                Box box = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.GetVolume():f2}");
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
