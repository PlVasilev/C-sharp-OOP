using System;
using System.Collections.Generic;
using System.Linq;

namespace LABeXSetsAndDict
{
    class LABeXSetsAndDict
    {
        static void Main(string[] args)
        {
            double[] numbres = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> countValues = new Dictionary<double, int>();

            foreach (var number in numbres)
            {
                if (countValues.ContainsKey(number))
                {
                    countValues[number]++;
                }
                else
                {
                    countValues.Add(number, 1);
                }
            }

            foreach (var item in countValues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
