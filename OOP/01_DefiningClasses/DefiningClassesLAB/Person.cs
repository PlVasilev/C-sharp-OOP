using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        //private string name;
        //private int age;
        //
        //
        //
        //public Person()
        //{
        //    this.Name = "No name";
        //    this.Age = 1;
        //}
        //
        //public Person(int age)
        //{
        //    this.Name = "No name";
        //    this.Age = age;
        //}
        //
        //public Person(string name,int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}
        //
        //public string Name
        //{
        //    get { return this.name; }
        //    set
        //    {
        //        this.name = value ?? throw new ArgumentNullException(); // = if(value == null){throw ne excep}
        //    }
        //}
        //
        //public int Age
        //{
        //    get { return this.age; }
        //    set { this.age = value; }
        //}

        //public string Name { get; set; } 
        //public Car Car { get; set; } 
        //public Company Company { get; set; }
        //public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
        //public List<Child> Children { get; set; } = new List<Child>();
        //public List<Parent> Parents { get; set; } = new List<Parent>();
        //public Person(string name)
        //{
        //    Name = name;
        //}
        //
        //public Person(string name, Car car, Company company, Pokemon pokemon, Child child, Parent parent)
        //{
        //    Name = name;
        //    Car = car;
        //    Company = company;
        //    Pokemons.Add(pokemon);
        //    Children.Add(child);
        //    Parents.Add(parent);
        //}
        //
        //public Person(string name,  Company company)
        //{
        //    Name = name;
        //    Company = company;
        //}
        //
        //
        //public Person(string name, Pokemon pokemon)
        //{
        //    Name = name;
        //    Pokemons.Add(pokemon);
        //}
        //
        //public Person(string name, Parent parent)
        //{
        //    Name = name;
        //    Parents.Add(parent);
        //}
        //
        //public Person(string name,  Child child)
        //{
        //    Name = name;
        //    Children.Add(child);
        //}
        //
        //public Person(string name, Car car)
        //{
        //    Name = name;
        //    Car = car;
        //}

        private List<Person> children;

        public Person()
        {
            this.children = new List<Person>();
        }

        public Person(string name, string date) : this()
        {
            this.Name = name;
            this.BirthDate = date;
        }

        public string Name { get; set; }

        public string BirthDate { get; set; }

        public IReadOnlyList<Person> Children
        {
            get { return this.children.AsReadOnly(); }
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }

        public void AddChildrenInfo(string name, string date)
        {
            if (this.children.FirstOrDefault(c => c.Name == name) != null)
            {
                this.children.FirstOrDefault(c => c.Name == name).BirthDate = date;
                return;
            }

            if (this.children.FirstOrDefault(c => c.BirthDate == date) != null)
            {
                this.children.FirstOrDefault(c => c.BirthDate == date).Name = name;
            }
        }

        public Person FindChildName(string childName)
        {
            return this.children.FirstOrDefault(c => c.Name == childName);
        }
    }
}
