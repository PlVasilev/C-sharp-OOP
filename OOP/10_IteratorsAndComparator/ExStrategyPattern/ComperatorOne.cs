using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExStrategyPattern
{
   public class ComperatorOne : IComparer<Person>
   {
       public int Compare(Person x, Person y)
       {
           int result = x.Name.Length.CompareTo(y.Name.Length);
           if (result == 0)
           {
               result = x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
           }

           return result;
       }
   }
}
