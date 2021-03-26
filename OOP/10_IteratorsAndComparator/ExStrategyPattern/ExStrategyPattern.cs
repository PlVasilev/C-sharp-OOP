using System;
using System.Collections.Generic;

namespace ExStrategyPattern
{
    class ExStrategyPattern
    {
        static void Main(string[] args)
        {
            SortedSet<Person> personsSortedSet = new SortedSet<Person>();
            HashSet<Person> personsHashSet = new HashSet<Person>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] personArr = Console.ReadLine().Split();
                Person person = new Person(personArr[0],int.Parse(personArr[1]));
                personsSortedSet.Add(person);
                personsHashSet.Add(person);
            }

            Console.WriteLine(personsSortedSet.Count);
            Console.WriteLine(personsHashSet.Count);

            //foreach (var person in personsByNaem)
            //{
            //    Console.WriteLine($"{person.Name} {person.Age}");
            //}
            //
            //foreach (var person in personsByAge)
            //{
            //    Console.WriteLine($"{person.Name} {person.Age}");
            //}
        }
    }
}
