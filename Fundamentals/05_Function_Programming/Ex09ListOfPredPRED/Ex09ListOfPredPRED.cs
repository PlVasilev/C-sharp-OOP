using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex09ListOfPredPRED
{
    class Ex09ListOfPredPRED
    {
        static void Main(string[] args)
        {
            var endNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).Distinct();

            Queue<int> numbers = new Queue<int>();

            Func<int, bool>[] predicates = dividers
                .Select(div => (Func<int, bool>)(n => n % div == 0))
                .ToArray();

            for (int i = 1; i <= endNumber; i++)
            {
                if (IsValid(predicates, i))
                {
                    numbers.Enqueue(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
        private static bool IsValid(Func<int, bool>[] predicates, int num)
        {
            foreach (var predicate in predicates)
            {
                if (!predicate(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
