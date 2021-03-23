using System;
using System.Linq;

namespace LABExFuncProgr
{
    class LABExFuncProgr
    {
        //public delegate string BinaryOperator(int x, int y); // == Func<int, int, string> opMulty = IsGreater; (inside main)

        static void Main(string[] args)
        {
            Func<int, int, string> opMulty = IsGreater; // generci Delegate
            Console.WriteLine(Calculator(4, 5, Multiply));
            Console.WriteLine(Calculator(90, 5, (x, y) => (x / y).ToString())); // with lamda expr whitout method
            Console.WriteLine(Calculator(4, 5, Add));
            Console.WriteLine(Calculator(4, 5, IsGreater));
        }

        public static string Calculator(int x, int y, Func<int, int, string> opr)
        {
            return opr(x, y);
        }

        public static string Multiply(int x, int y) => (x * y).ToString();

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater(int x, int y)
        {
            return (x > y).ToString();
        }
    }
}
