using Ex03WildFarm.AbstactClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Classes
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Eat(int quant, string foodType)
        {
            ProduceSound();
            if (foodType == "Meat")
            {
                Weight += quant * 1;
                FoodEaten += quant;             
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType}!");
            }

        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
