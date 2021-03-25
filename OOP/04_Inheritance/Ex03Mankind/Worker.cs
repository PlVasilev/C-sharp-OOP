using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03Mankind
{
    class Worker : Human
    {
        private double weekSalary;
        private double hoursPerDay;

        internal double WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }
        internal double HowersPerDay
        {
            get => hoursPerDay;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                hoursPerDay = value;
            }
            
        }
        public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay)
        {
            FirstName = firstName;
            LastName = lastName;
            WeekSalary = weekSalary;
            HowersPerDay = hoursPerDay;
        }
    }
}
