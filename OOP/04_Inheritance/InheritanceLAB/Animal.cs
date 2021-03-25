using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLAB
{
    public abstract class Animal // means - CAN NOT HAVE INSTANCES and can not be used as static
    {
        internal int Age { get; set; }//only visable in the assembly 

        public string Name { get; set; }

        protected int Weigth { get; set; }

        public virtual void Move() // Only VIRUAL methods can Be OverRitten;
        {
            Console.WriteLine("Move");
        }

        public static void Eat()
        {

        }
    }
}
