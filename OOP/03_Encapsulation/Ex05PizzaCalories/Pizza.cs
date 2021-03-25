using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05PizzaCalories
{
    public class Pizza
    {
        public string Name { get; private set; }
        private Dough Dough { get; set; }
        private List<Topping> Toppings { get; set; } = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            if ((string.IsNullOrWhiteSpace(name) || name == string.Empty) || name.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                
            }
            else
            {
                Name = name;
            }
            Dough = dough;
        }

        public List<Topping> AddTopping(Topping topping)
        {
            if (Toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                Toppings.Add(topping);
                return Toppings;
            }
        }

        public int ToppingCout(List<Topping> Toppings)
        {
            return Toppings.Count;
        }

        public double PizzaCalories()
        {
            double sum = 0;
            foreach (var item in Toppings)
            {
                sum += item.Calories;
            }
            return Dough.Calories + sum;
        }

    }
}
