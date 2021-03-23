using System;
using System.Linq;
using System.Numerics;

namespace Matrix02CubicRube
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            long[,,] cube = new long[num, num, num];

            string input = "";
            int hits = 0;
            while ((input = Console.ReadLine()) != "Analyze")
            {
                
                long[] inputArr = input.Split().Select(long.Parse).ToArray();
                long x = inputArr[0];
                long y = inputArr[1];
                long z = inputArr[2];
                long value = inputArr[3];
                if (x >= 0 && x < num && y >= 0 && y < num && z >= 0 && z < num && cube[x,y,z] == 0 && value != 0)
                {
                    cube[x, y, z] = value;
                    hits++;
                }
            }
            BigInteger sum = 0;
            foreach (var item in cube)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            Console.WriteLine((num*num*num) - hits);
        }
    }
}
