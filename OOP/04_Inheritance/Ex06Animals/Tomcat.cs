using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string animalTipe, string name, int age,string gender) : base(animalTipe, name,age,gender)
        {
            Gender = "Male";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
