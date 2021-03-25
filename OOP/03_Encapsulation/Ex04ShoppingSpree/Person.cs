using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
                ;
            }
        }

        public decimal Money
        {
            get
            {
                return money;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                {
                    money = value;
                }
                ;
            }
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }
    }
}
