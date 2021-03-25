using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06Animals
{
    class Dog : Animal
    {
        public Dog(string anymalType, string name, int age, string gender) : base(anymalType, name, age, gender)
        {

        }
        
        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
