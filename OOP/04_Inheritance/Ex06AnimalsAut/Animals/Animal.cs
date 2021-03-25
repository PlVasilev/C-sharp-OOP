using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06AnimalsAut.Animals
{
    public abstract class Animal
    {
       
        private string name;
        private int? age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Genger = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (value == null || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }


        public int? Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }


        public string Genger
        {
            get { return gender; }
            private set
            {
                if (value == null || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public virtual void ProduceSound()
        {
            
            Console.WriteLine("fsdf");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Genger}";
        }
    }
}
