using System;

namespace Ex05PizzaCalories
{
    class Ex05PizzaCalories
    {
        static void Main(string[] args)
        {          
            try
            {
                string[] pizzaNameArr = Console.ReadLine().Split(" ");
                string pizzaName = pizzaNameArr[1];
                string[] doughtArr = Console.ReadLine().Split(" ");
                Dough dough = new Dough(doughtArr[1], doughtArr[2], double.Parse(doughtArr[3]));
                Pizza pizza = new Pizza(pizzaName, dough);
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] inputArr = input.Split(" ");
                    Topping topping = new Topping(inputArr[1], double.Parse(inputArr[2]));
                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }
                Console.WriteLine($"{pizzaName} - {pizza.PizzaCalories():f2} Calories.");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }
    }
}
