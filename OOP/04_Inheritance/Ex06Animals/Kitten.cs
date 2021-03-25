using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06Animals
{
    class Kitten : Cat
    {
        public Kitten(string animalTipe, string name, int age, string gender) : base(animalTipe, name, age, gender)
        {
            Gender = "Female";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
