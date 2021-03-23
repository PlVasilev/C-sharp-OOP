using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueueEx
{
    class StackAndQueueEx
    {
        static void Main(string[] args)
        {
            int pums = int.Parse(Console.ReadLine());
            Queue<long[]> fuelMile = new Queue<long[]>(pums);
            for (int i = 0; i < pums; i++)
            {
                long[] fuelMilage = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                fuelMile.Enqueue(fuelMilage);
            }

            int index = 0;

            while (true)
            {
                long totalFuel = 0;

                foreach (var item in fuelMile)
                {
                    long fuel = item[0];
                    long distance = item[1];

                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        long[] nextPump = fuelMile.Dequeue();
                        fuelMile.Enqueue(nextPump);
                        break;
                    }

                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
