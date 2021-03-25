using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLAB
{
    public class Puppy : Dog
    {
        public bool CanGoOUt { get; set; }


        public Puppy(string name, int age) : base(name) // constuctor Inharitance 
        {
            // name goes as proparty to the base class
            Name += " - changed"; // but we can change them as we want
            Age = age;

            if (age > 5) // we can do validations
            {
                CanGoOUt = true;    // we can add prop
            }
           
        }

        public void Weep()
        {

        }
       // public override void Move() // Cuz we have used sealed we can not overRide here
                                      // so Move stays as it was in the parrent Class
       //{
       //    Console.WriteLine("Crow");
       //}
    }
}
