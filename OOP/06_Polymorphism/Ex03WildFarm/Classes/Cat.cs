using Ex03WildFarm.AbstactClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Classes
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(int quant, string foodType)
        {
            ProduceSound();
            if (foodType == "Vegetable" || foodType == "Meat")
            {
                Weight += quant * 0.3;
                FoodEaten += quant;
               
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {foodType}!");
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
