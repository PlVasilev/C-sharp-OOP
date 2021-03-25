using Ex03WildFarm.AbstactClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Classes
{
    public class Owl : Bird
    {
        public Owl(string name, double weight,  double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eat(int quant, string foodType)
        {
            ProduceSound();
            if (foodType == "Meat")
            {
                Weight += quant * 0.25;
                FoodEaten += quant;
                
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType}!");
            }

        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
