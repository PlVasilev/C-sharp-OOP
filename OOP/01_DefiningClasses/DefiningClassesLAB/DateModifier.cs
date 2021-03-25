using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private double days;

        public double Days { get; set; }

        public void getDays(string firstDate, string secondDate)
        {
            DateTime DateOne = DateTime.ParseExact(firstDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime DateTwo = DateTime.ParseExact(secondDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(Math.Abs((DateTwo - DateOne).TotalDays));            
        }
    }
}
