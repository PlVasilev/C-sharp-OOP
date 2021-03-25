using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.AbstactClasses
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }
    }
}
