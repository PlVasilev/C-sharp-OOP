using System;
using System.Linq;

namespace ExFuncProgr
{
    class ExFuncProgr
    {
        static void Main(string[] args)
        {
 
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Console.WriteLine(minFunc(arr));
        }

        public static Func<int[], int> minFunc = x =>
        {
            int min = int.MaxValue;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            
            return min;
        };
    }
}
