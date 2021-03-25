using Ex03WildFarm.AbstactClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Classes
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight,  livingRegion)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(int quant, string foodType)
        {
            ProduceSound();
            if (foodType == "Vegetable" || foodType == "Fruit")
            {
                Weight += quant * 0.1;
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
