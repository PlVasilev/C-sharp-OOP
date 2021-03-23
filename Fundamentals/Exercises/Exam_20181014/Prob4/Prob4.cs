using System;
using System.Collections.Generic;
using System.Linq;

namespace Prob4
{
    class Prob4
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] botlArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>();
            Stack<int> botles = new Stack<int>();

            for (int i = 0; i < cupsArr.Length; i++)
            {
                cups.Enqueue(cupsArr[i]);
            }
            for (int i = 0; i < botlArr.Length; i++)
            {
                botles.Push(botlArr[i]);
            }

            int wastedWhater = 0;

            while (cups.Count > 0 && botles.Count > 0)
            {
                int cup = cups.Dequeue();
                int bottle = botles.Pop();
                if (bottle - cup >= 0)
                {
                    wastedWhater += bottle - cup;
                }
                else 
                {
                    while (true)
                    {
                        cup = cup-bottle;
                        if (cup > 0)
                        {
                            bottle = botles.Pop();
                        }
                        else
                        {
                            wastedWhater -= cup;
                            break;
                        }
                    }
                }
            }
            if (cups.Count == 0)
            {
                Console.Write("Bottles: ");
                Console.WriteLine(string.Join(" ",botles));
                Console.WriteLine($"Wasted litters of water: {wastedWhater}");
            }
            else
            {
                Console.Write("Cups: ");
                Console.WriteLine(string.Join(" ", cups));
                Console.WriteLine($"Wasted litters of water: {wastedWhater}");
            }
        }
    }
}
