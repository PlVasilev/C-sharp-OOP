using Ex03WildFarm.AbstactClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Classes
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight,  livingRegion)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eat(int quant, string foodType)
        {
            ProduceSound();
            if ( foodType == "Meat")
            {
                Weight += quant * 0.4;
                FoodEaten += quant;
              
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {foodType}!");
            }

        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
