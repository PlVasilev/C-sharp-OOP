using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03WildFarm.AbstactClasses
{
   public  abstract class Food
    {
        public int Quantity { get; set; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
