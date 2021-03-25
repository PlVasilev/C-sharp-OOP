using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06Animals
{
    public class Cat : Animal
    {
        public Cat(string anymalType, string name, int age, string gender) : base(anymalType, name, age, gender)
        {

        }


        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
