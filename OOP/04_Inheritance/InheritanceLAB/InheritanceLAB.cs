using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceLAB
{
    class InheritanceLAB
    {
        static void Main(string[] args)
        {

            var dog = new Dog("Djaf"); // inharits anymal
            var puppy = new Puppy("Malcho", 10); // inherit god which inherits animal
            var cat = new Cat();

            Console.WriteLine($"{dog.Name} {puppy.Name}");

            dog.Age = 15;
            cat.Name = "Maca";
            puppy.Age = 2;
            dog.Move();
            puppy.Move();
            // cat.Weight Protected is no accecible outside only access in the class or child Class 

            Console.WriteLine(puppy.CanGoOUt);
            Console.WriteLine(puppy.Age);// internal can only be used in the SAME ASSEMBLY (Solution)

           // Composition 
           // when we use Class as a Prop for other Class

            // Delegation // we delegate some prop or method 
            //class Laptop
            //     {
            //     Monitor monitor;
            //     void IncrBrightness()
            //     monitor.Brighten();
            //
            //     void DecrBrightness()
            //     monitor.Dim();
            //     }


    }
}
}
