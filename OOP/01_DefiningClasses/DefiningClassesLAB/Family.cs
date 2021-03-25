using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses // first fields, second constuctors, third properties, forth methods
{
    public class Family
    {
        private List<Person> people; // fielad

        public Family() // constructor
        {
            this.People = new List<Person>(); // initialize the class so it wont throw excep
        }

        public List<Person> People // propertie
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person member)
        {
            if (member == null)
            {
                throw new Exception();
            }
            this.People.Add(member);
        }

        //public Person GetOldestMember()
        //{
        //    return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
        //} 
    }
}
