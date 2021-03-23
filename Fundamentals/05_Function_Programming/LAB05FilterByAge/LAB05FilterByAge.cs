using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB05FilterByAge
{
    class LAB05FilterByAge
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] person = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                people.Add(new KeyValuePair<string, int>(person[0],int.Parse(person[1])));
            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] printPatern = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            people.Where(p => filter == "younger" ? p.Value < age : p.Value > age)
                .ToList()
                .ForEach(p => Printer(p,age, printPatern));
        }

        static void Printer(KeyValuePair<string, int> person, int age, string[] printerPat)
        {
            if (printerPat.Length == 2)
            {
                Console.WriteLine(printerPat[0] == "name" ? $"{person.Key} - {person.Value}" : $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(printerPat[0] == "name" ? $"{person.Key}" : $"{person.Value}");
            }
        }
    }
}
