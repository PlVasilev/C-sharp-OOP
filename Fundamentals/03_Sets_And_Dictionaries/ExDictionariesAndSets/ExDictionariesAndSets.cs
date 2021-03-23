using System;
using System.Collections.Generic;
using System.Linq;

namespace ExDictionariesAndSets
{
    class ExDictionariesAndSets
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = num[0];
            int m = num[1];
            HashSet<int> nSet = new HashSet<int>();
            HashSet<int> mSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                nSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0; j < m; j++)
            {
                var num1 = int.Parse(Console.ReadLine());
                mSet.Add(num1);
            }

            var results = nSet.Intersect(mSet);

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
