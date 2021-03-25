using Ex03WildFarm.AbstactClasses;
using Ex03WildFarm.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.Controllers
{
   public class Engine
    {
        List<Animal> animals = new List<Animal>();

        public void Run()
        {
            string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (inputArr[0] != "End")
            {
                string animalType = inputArr[0];
                string name = inputArr[1];
                double weight = double.Parse(inputArr[2]);

                switch (animalType)
                {
                    case "Hen":
                        Animal hen = new Hen(name, weight, double.Parse(inputArr[3]));
                        animals.Add(hen);
                        string[] henFood = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        hen.Eat(int.Parse(henFood[1]), henFood[0]);
                        break;
                    case "Owl":
                        Animal owl = new Owl(name, weight, double.Parse(inputArr[3]));
                        animals.Add(owl);
                        string[] owlFood = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        owl.Eat(int.Parse(owlFood[1]), owlFood[0]);
                        break;
                    case "Mouse":
                        Animal mouse = new Mouse(name, weight, inputArr[3]);
                        animals.Add(mouse);
                        string[] mouseFood = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        mouse.Eat(int.Parse(mouseFood[1]), mouseFood[0]);
                        break;
                    case "Dog":
                        Animal dog = new Dog(name, weight, inputArr[3]);
                        animals.Add(dog);
                        string[] dogFood = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        dog.Eat(int.Parse(dogFood[1]), dogFood[0]);
                        break;
                    case "Cat":
                        Animal cat = new Cat(name, weight, inputArr[3], inputArr[4]);
                        animals.Add(cat);
                        string[] food = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        cat.Eat(int.Parse(food[1]), food[0]);
                        break;
                    case "Tiger":
                        Animal tiger = new Tiger(name, weight, inputArr[3], inputArr[4]);
                        animals.Add(tiger);
                        string[] tigerFood = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        tiger.Eat(int.Parse(tigerFood[1]), tigerFood[0]);
                        break;
                    default:
                        break;
                }
                inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
  
    }
}
