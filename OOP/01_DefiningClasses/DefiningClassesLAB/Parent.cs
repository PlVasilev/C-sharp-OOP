using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Parent
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public Parent(string name, string birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
    }
}
