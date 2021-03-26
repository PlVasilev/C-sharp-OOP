using System;
using System.Collections.Generic;

namespace ExComparingObjects
{
    class ExComparingObjects
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                Person person = new Person(input[0], int.Parse(input[1]), input[2]);
                persons.Add(person);
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= persons.Count)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Person personToCompair = persons[index+1];

                int equals = 0;

                for (int i = 0; i < persons.Count; i++)
                {
                    equals = personToCompair.IsEqual(persons[i]) == true ? equals += 1 : equals;
                }

                if (equals == 1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine($"{equals} {persons.Count - equals} {persons.Count}");
                }
            }
           
        }
    }
}
