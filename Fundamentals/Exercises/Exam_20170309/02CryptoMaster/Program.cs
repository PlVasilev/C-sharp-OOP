using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CryptoMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            int counter = 0;

            for (int step = 1; step < nums.Length; step++)
            {

                for (int j = 0; j < nums.Length; j++)
                {
                    int rotations = 1;

                    int currIndex = j;
                    int nextIndex = (currIndex + step) % nums.Length;

                    while (nums[nextIndex] > nums[currIndex])
                    {
                        rotations++;

                        currIndex = nextIndex;
                        nextIndex = (currIndex + step) % nums.Length;
                    }
                    if (rotations > counter)
                    {
                        counter = rotations;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
