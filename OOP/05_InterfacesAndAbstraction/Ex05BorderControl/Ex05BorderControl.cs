using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex05BorderControl
{
   public class Ex05BorderControl
    {
        static void Main(string[] args)
        {
            List<Bialogical> entrees = new List<Bialogical>();
            int num = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                if (input.Length == 4 )
                {
                    Bialogical entree = new Citizen(input[0]);
                    entrees.Add(entree);
                }
                else if (input.Length == 3)
                {
                    Bialogical entree = new Rebel(input[0]);
                    entrees.Add(entree);
                }
                else
                {
                    if (entrees.Any(x => x.Name == input[0]))
                    {
                        string type = entrees.Where(x => x.Name == input[0]).FirstOrDefault().GetType().ToString();
                        if (type == "Ex05BorderControl.Citizen")
                        {
                            entrees.Where(x => x.Name == input[0]).FirstOrDefault().Food += 10;
                        }
                        else if (type == "Ex05BorderControl.Rebel")
                        {
                            entrees.Where(x => x.Name == input[0]).FirstOrDefault().Food += 5;
                        }
                    }
                               
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(entrees.Sum(x => x.Food));
        }
    }
}
