using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Employee
    {
        public Employee(string name, double salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = name;
            this.Department = name;
            this.Email = "n/a";
            this.Age = -1;       
        }

        public Employee(string name, double salary, string position, string department, string email)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = name;
            this.Department = name;
            this.Email = email;
            this.Age = -1;
        }

        public Employee(string name, double salary, string position, string department, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = name;
            this.Department = name;
            this.Email = "n/a";
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = name;
            this.Department = name;
            this.Email = email;
            this.Age = age;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
