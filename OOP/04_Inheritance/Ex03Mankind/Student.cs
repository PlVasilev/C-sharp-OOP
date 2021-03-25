using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex03Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        internal string FacultyNumber {
            get
            {
                return facultyNumber;
            }
            set
            {
                Regex r = new Regex("^[a-zA-Z0-9]*$");
                if (value.Length > 4 && value.Length < 11 && r.IsMatch(value))
                {
                    facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }

        public Student(string name, string lastName, string facultyNumer)
        {
            FirstName = name;
            LastName = lastName;
            FacultyNumber = facultyNumer;
        }
    }
}
