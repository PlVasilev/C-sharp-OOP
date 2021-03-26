using System;
using System.Collections.Generic;
using System.Text;

namespace ExStrategyPattern
{
   public class ComperatorAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
