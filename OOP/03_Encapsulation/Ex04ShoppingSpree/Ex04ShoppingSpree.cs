using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04ShoppingSpree
{
    class Ex04ShoppingSpree
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] persons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in persons)
            {
                string[] itemArr = item.Split("=");
                try
                {
                    Person person = new Person(itemArr[0], decimal.Parse(itemArr[1]));
                    people.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                } 
            }

            string[] productsArr = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in productsArr)
            {
                string[] itemArr = item.Split("=");
                try
                {
                    if (decimal.Parse(itemArr[1]) >= 0)
                    {
                        Product product = new Product(itemArr[0], decimal.Parse(itemArr[1]));
                        products.Add(product);
                    }
                    else
                    {
                        Console.WriteLine("Money cannot be negative");
                        return;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string person = inputArr[0];
                string product = inputArr[1];

               Person currentPerson = people.Where(x => x.Name == person).FirstOrDefault();
               Product currentProduct = products.Where(x => x.Name == product).FirstOrDefault();
                if (currentPerson.Money >= currentProduct.Cost )
                {
                    currentPerson.Products.Add(currentProduct);
                    currentPerson.Money -= currentProduct.Cost;
                    Console.WriteLine($"{person} bought {product}"); 

                }
                else
                {
                    Console.WriteLine($"{person} can't afford {product}");
                }
                input = Console.ReadLine();
            }
            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", GetProducts(person.Products))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
           
        }

        public static List<string> GetProducts(List<Product> products)
        {
            List<string> productNames = new List<string>();
            foreach (var item in products)
            {
                productNames.Add(item.Name);
            }
            return productNames;
        }
    }
}
