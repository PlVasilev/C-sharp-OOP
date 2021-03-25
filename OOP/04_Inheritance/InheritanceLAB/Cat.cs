using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLAB
{
    public class Cat : Animal
    {
        public float Weigth { get; set; }

        public void Meow()
        {
            if (true)
            {
                double weight = 2.0;

                this.Weigth = 6.4f;
                base.Weigth = (int)weight;
            }
        }
    }
}
