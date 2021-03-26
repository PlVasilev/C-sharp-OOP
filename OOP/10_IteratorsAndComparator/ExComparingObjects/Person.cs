using System;
using System.Collections.Generic;
using System.Text;

namespace ExComparingObjects
{
   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name,int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public bool IsEqual(Person other)
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return false;
            }
            else if (Age.CompareTo(other.Age) != 0)
            {
                return false;
            }
            else if (Town.CompareTo(other.Town) != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
