using System;
using System.Collections.Generic;
using System.Text;

namespace ExDatabase
{
    public class Person
    {
        public Person(string name, long id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; private set; }
        public long Id { get; private set; }
    }
}
