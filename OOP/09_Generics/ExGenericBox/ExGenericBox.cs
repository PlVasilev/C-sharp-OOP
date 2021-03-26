using System.Diagnostics;
using System.Linq;

namespace ExGenericBox
{
    using System;
    public class ExGenericBox
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                box.Items.Add(double.Parse(Console.ReadLine()));
            }

            double match = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GetCount(match));
        }
    }
}
