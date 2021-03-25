using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        //public int Health { get; set; }

        public Pokemon(string name, string element)
        {
            Name = name;
            Type = element;
            //Health = health;
        }
    }
}
