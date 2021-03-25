using Ex03WildFarm.AbstactClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Classes
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat(int quant, string foodType)
        {
            ProduceSound();
            if (foodType == "Vegetable" || foodType == "Meat" || foodType == "Seeds" || foodType == "Fruit")
            {
                Weight += quant * 0.35;
                FoodEaten += quant;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {foodType}!");
            }

        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
