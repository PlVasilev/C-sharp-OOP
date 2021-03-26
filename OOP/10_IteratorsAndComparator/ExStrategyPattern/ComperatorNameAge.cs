using System;
using System.Collections.Generic;
using System.Text;

namespace ExStrategyPattern
{
   public class ComperatorNameAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.CompareTo(y.Name);
            if (result == 0)
            {
                result = x.Age.CompareTo(y.Age);
            }

            return result;
        }
    }
}
