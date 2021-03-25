using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{                                       // if Person is encapsulated
    internal static class PersonExtension // we extend the functionality of Person Class it must pe Private
    {      
        //we will make method that work with instance of Person

        public static bool IsAdult(this Person person) 
        {
            return person.Age >= 18;
        }
    }
}
