using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    internal class Person
    {
        private string lastname2;
        private decimal selary;

        public string FirstName2 { get; set; }

        public string LastName2 {
            get
            {
                return lastname2;
            }
            set
            {
                lastname2 = value;
            }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 560)
                {
                    throw new ArgumentException("Salary is TOO LOW FFS");
                }
                else
                {
                    salary = value;
                }
            }
        }


        public string FirstName()
        {
            return this.FirstName2;
        }
        public string FirstNameLambda => FirstName2; // same as above just we can use or not ()
        public string FirstNameLambda2(Person x) => x.FirstName2; // if we need someting in the method 


        public int Age { get; set; }

        public Person(string firstName)
        {
           FirstName2 = firstName; // the field = the prop
        }

        public Person(string lastName, int age) : this(lastName) // chaining
        {
            Age = age;

        }
        public Person SetAge()
        {
            Age = 1;
            return this;
        }

        public Person SetAge(int age) // overLOAD method with the same name but with Different parameters
        {
            Age = age;
            return this;
        }

        // overRide we dont change the deffinition of toString() we change his inplementation beween {}
        public override string ToString() // when we overRide we can NOT change what it returns in this case STRING
        {
            return $"{FirstName2} {LastName2}";  // base = this but for the parent Class of this
        }

        public Person GetMe()
        {
            return this;
        }

        public void IncreaseSalary(int percent)
        {
            if (percent < 0 || percent > 100)
            {
                throw new ArgumentException("FFF");
            }
            else
            {
                if (Age < 30)
                {
                    Console.WriteLine(Salary + Salary * percent / 200);
                }
                else
                {
                    Console.WriteLine(Salary + Salary * percent / 100);
                }
            }
        }
    }
}
