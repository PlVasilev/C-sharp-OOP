using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.AbstactClasses
{
   public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; } = 0;

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public virtual void ProduceSound()
        {
        }

        public virtual void Eat(int quant,string foodType)
        {
            
        }
    }
}
