using System;
using System.Collections.Generic;
using System.Text;

namespace ExPetClinics
{
   public class Pet
    {
        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }
    }
}
