using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03Mankind
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        internal string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: firstName");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }
                else
                {
                    firstName = value;
                }
               
            }
        }

        internal string LastName
        {
            get => lastName;
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
                }
                lastName = value;
            }
        }   
                
    }
}
