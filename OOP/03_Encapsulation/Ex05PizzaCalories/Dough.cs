using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05PizzaCalories
{
    public class Dough
    {
        private string FlourType { get; set; }
        private string BakingTechnique { get; set; }
        private double Weight { get; set; }
        public double Calories
        {
            get;
            private set;
        }

        public Dough(string flourType, string bakingTecknique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTecknique;
            
            double calories = 0;
            switch (flourType.ToLower())
            {
                case "white":
                    calories = weight * 1.5;
                    break;
                case "wholegrain":
                    calories = weight;
                    break;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
            switch (bakingTecknique.ToLower())
            {
                case "crispy":
                    calories *=  0.9;
                    break;
                case "chewy":
                    calories *= 1.1;
                    break;
                case "homemade":
                    break;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
            if (weight < 1 || weight > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");

            }
            Weight = weight;
            Calories = calories * 2;
        }
    }
}
