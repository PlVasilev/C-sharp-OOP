using System;
using System.Collections.Generic;

namespace Ex06Animals
{
    class Ex06Animals
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string inputType = Console.ReadLine();
            while (inputType != "Beast!")
            {
                string[] animalArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (inputType)
                    {
                        case "Dog":
                            Animal animald = new Dog(inputType, animalArr[0],int.Parse(animalArr[1]), animalArr[2]);
                            animals.Add(animald);
                            break;
                        case "Cat":
                            Animal animalc = new Cat(inputType, animalArr[0], int.Parse(animalArr[1]), animalArr[2]);
                            animals.Add(animalc);
                            break;
                        case "Frog":
                            Animal animalf = new Frog(inputType, animalArr[0], int.Parse(animalArr[1]), animalArr[2]);
                            animals.Add(animalf);
                            break;
                        case "Kitten":
                            Animal animalk = new Kitten(inputType, animalArr[0], int.Parse(animalArr[1]), animalArr[2]);
                            animals.Add(animalk);
                            break;
                        case "Tomcat":
                            Animal animalt = new Tomcat(inputType, animalArr[0], int.Parse(animalArr[1]), animalArr[2]);
                            animals.Add(animalt);
                            break;
                        default:
                            break;
                    }
                   
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                inputType = Console.ReadLine();
            }
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i]);
                animals[i].ProduceSound();
            }
        }
    }
}
