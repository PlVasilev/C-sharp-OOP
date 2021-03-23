using System;
using System.Collections.Generic;
using System.Linq;

namespace Dic03GreedyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> bag = new Dictionary<string, Dictionary<string, long>>();
            bag.Add("Gold", new Dictionary<string, long>());
            bag.Add("Gem", new Dictionary<string, long>());
            bag.Add("Cash", new Dictionary<string, long>());

            long capacyty = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i+=2)
            {
                string itemToAdd = input[i].ToLower();
                long valueToAdd = long.Parse(input[i + 1]);

                if (itemToAdd == "gold")
                {
                    if (bag.Values.Sum(x => x.Sum(s => s.Value)) + valueToAdd <= capacyty)
                    {
                        itemToAdd = input[i];
                        if (!bag["Gold"].ContainsKey(itemToAdd))
                        {
                            bag["Gold"].Add(itemToAdd, valueToAdd);                        
                        }
                        else
                        {
                            bag["Gold"][itemToAdd] += valueToAdd;
                        }
                    }
                }
                else if (itemToAdd.Length == 3)
                {
                    if (bag.Values.Sum(x => x.Sum(s => s.Value)) + valueToAdd <= capacyty && 
                        bag["Cash"].Sum(x => x.Value) + valueToAdd <= bag["Gem"].Sum(x => x.Value))
                    {
                        itemToAdd = input[i];
                        if (!bag["Cash"].ContainsKey(itemToAdd))
                        {
                            bag["Cash"].Add(itemToAdd, valueToAdd);
                        }
                        else
                        {
                            bag["Cash"][itemToAdd] += valueToAdd;
                        }
                    }
                }
                else if (itemToAdd.Length > 3 && itemToAdd.EndsWith("gem"))
                {
                    if (bag.Values.Sum(x => x.Sum(s => s.Value)) + valueToAdd <= capacyty &&
                        bag["Gem"].Sum(x => x.Value) + valueToAdd <= bag["Gold"].Sum(x => x.Value))
                    {
                        itemToAdd = input[i];
                        if (!bag["Gem"].ContainsKey(itemToAdd))
                        {
                            bag["Gem"].Add(itemToAdd, valueToAdd);
                        }
                        else
                        {
                            bag["Gem"][itemToAdd] += valueToAdd;
                        }
                    }
                }
            }

            foreach (var type in bag.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (type.Value.Count != 0)
                {
                    Console.WriteLine($"<{type.Key}> ${type.Value.Values.Sum()}");
                }
                foreach (var item in type.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
               
            }
        }
    }
}
