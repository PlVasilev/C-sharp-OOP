using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Child
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public Child(string name, string birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
    }
}
