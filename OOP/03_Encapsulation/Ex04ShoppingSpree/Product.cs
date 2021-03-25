using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04ShoppingSpree
{
   public    class Product
    {
        private string name;
        private decimal cost;
    
        public string Name { get; }
        public decimal Cost { get; }

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
