using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03PeriodicTable
{
    class Ex03PeriodicTable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string,int>> wardrope = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] colorClothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = colorClothes[0];
                string[] clothes = colorClothes[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrope.ContainsKey(color))
                    {
                        wardrope[color] = new Dictionary<string, int>(); 
                    }
                    if (!wardrope[color].ContainsKey(clothes[j]))
                    {
                        wardrope[color][clothes[j]] = 1;
                    }
                    else
                    {
                        wardrope[color][clothes[j]]++;
                    }
                }
            }
            string[] clotesToWare = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in wardrope)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var items in item.Value)
                {
                    Console.Write($"* {items.Key} - {items.Value}");
                    if (item.Key == clotesToWare[0] && items.Key == clotesToWare[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
