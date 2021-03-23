using System;
using System.Collections.Generic;

namespace ExSets
{
    class LabExSets
    {
        static void Main(string[] args)
        {
            var entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> inCars = new HashSet<string>();

            while (entry[0] != "END")
            {
                switch (entry[0])
                {
                    case "IN":
                        inCars.Add(entry[1]);
                        break;
                    case "OUT":
                        inCars.Remove(entry[1]);
                        break;
                    default:
                        break;
                }
                entry = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (inCars.Count > 0)
            {
                foreach (var item in inCars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }

    }
}
