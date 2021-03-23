using System;
using System.Linq;

namespace LAB02SumNumbers
{
    class LAB02SumNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
           .Select(Parce)
           .ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());   
           }
        public static Func<string, int> Parce = n =>
        {
            int result = 0;
            if (int.TryParse(n,out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        };

    }
}
