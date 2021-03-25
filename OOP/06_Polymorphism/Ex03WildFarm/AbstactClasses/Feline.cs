using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.AbstactClasses
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; set; }

        public Feline(string name, double weight, string livingRegion,string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }
    }
}
