using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05PizzaCalories
{
   public class Topping
    {
        private string Sauce { get; set; }
        private double Weight { get; set; }
        public double Calories
        {
            get;
            private set;
        }

        double caloeris = 0;
        public Topping(string sause, double weight)
        {
            switch (sause.ToLower())
            {
                case "meat":
                    caloeris = weight * 1.2;
                    break;
                case "veggies":
                    caloeris = weight * 0.8;
                    break;
                case "cheese":
                    caloeris = weight * 1.1;
                    break;
                case "sauce":
                    caloeris = weight * 0.9;
                    break;
                default:
                    throw new ArgumentException($"Cannot place {sause} on top of your pizza.");
            }
            Sauce = sause;

            if (weight < 1 || weight > 50)
            {
                throw new ArgumentException($"{sause} weight should be in the range [1..50].");
            }
            Weight = weight;

            Calories = caloeris * 2;

        }
    }
}
