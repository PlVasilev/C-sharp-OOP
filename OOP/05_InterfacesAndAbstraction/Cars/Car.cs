using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car : ICar // class car MUST Have everything that is in ICar
    {
        public string Model { get; set; } 
        public virtual string Color { get; set; }

        public virtual string Start()  // we haveimplementation here it can be virtual so it can be overRitten
        {
            return "Car started!";
        }

        public abstract string Stop(); // now we make a MUST the one who inhertist it to implement the method
  
    }
}
