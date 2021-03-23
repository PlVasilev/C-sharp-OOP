    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace LabEx07SoftUniParty
    {
        class LabEx07SoftUniParty
        {
            static void Main(string[] args)
            {
                HashSet<string> guests = new HashSet<string>();

                string entry = Console.ReadLine();

                while (entry?.ToLower() != "party")
                {
                    guests.Add(entry);
                    entry = Console.ReadLine();
                }
                    entry = Console.ReadLine();

                while (entry?.ToLower() != "end")
                {
                    guests.Remove(entry);
                    entry = Console.ReadLine();
                }
                Console.WriteLine(guests.Count);
                HashSet<string> vips = new HashSet<string>();

                foreach (var item in guests)
                {
                    int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    if (numbers.Contains(item[0]))
                    {
                        vips.Add(item);
                    }
                }
                foreach (var item in vips)
                {
                    Console.WriteLine(item);
                }

                HashSet<string> novips = new HashSet<string>();

                foreach (var item in guests)
                {
                    int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    if (!numbers.Contains(item[0]))
                    {
                        novips.Add(item);
                    }
                }
                foreach (var item in novips)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
