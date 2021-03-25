using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class FamilyMember
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public FamilyMember(string name,string date)
        {
            Name = name;
            Date = date;
        }
    }
}
