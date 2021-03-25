using NameofCalculator;
using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            try
            {
                Sqrt(-1);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Error" + ae.Message ); 
            }
        }
        public static double Sqrt(double value)
        {
            
            if (value < 0)
            {
                var ae = new ArgumentOutOfRangeException(nameof(value), value, "Sqrt is not defined for negative numbers"); // !!!
                throw ae;
            }


            return Math.Sqrt(value);
        }

        public static int? sum(int? a, int? b)
        {
            if (a == null || b == null)
            {
                throw new MathException("Argument is Null", '+');
            }
            return a + b;
        }
    }
}
