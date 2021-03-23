using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToArray();

            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                bool canDiv = true;
                for (int j = 0; j < dividers.Length; j++)
                {
                    
                    if (i % dividers[j] != 0)
                    {
                        canDiv = false;
                        break;
                    }
                    
                }
                if (canDiv == true)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
