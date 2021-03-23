using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04FindEvensOrOdds
{
    class Ex04FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string action = Console.ReadLine();
            int counter = 0;
            List<int> numArr = new List<int>();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                numArr.Add(i);
            }
            Predicate<int> even = x => { return x % 2 == 0; };
            Predicate<int> odd = x => { return x % 2 != 0; };

            List<int> result = new List<int>();
            if (action == "odd")
            {
                result = numArr.FindAll(odd);
            }
            else
            {
                result = numArr.FindAll(even);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
