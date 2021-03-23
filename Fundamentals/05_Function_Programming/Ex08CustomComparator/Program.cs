using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08CustomComparator
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", sort(arr)));
        }

        public static Func<int[], List<int>> sort = x =>
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i < x.Length; i++)
            {
                if (Math.Abs(x[i]) % 2 != 0)
                {
                    odd.Add(x[i]);
                }
                else
                {
                    even.Add(x[i]);
                }
            }
            odd.Sort();
            even.Sort();
            List<int> result = new List<int>();
            for (int i = 0; i < even.Count; i++)
            {
                result.Add(even[i]);
            }
            for (int i = 0; i < odd.Count; i++)
            {
                result.Add(odd[i]);
            }
            
            return result;
        };
    }
}
