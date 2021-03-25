using Ex08MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Classes
{
    public class Engineer : Private, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, string[] repairs) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
            for (int i = 0; i < repairs.Length; i+=2)
            {
                Repairs.Add(new KeyValuePair<string, int>(repairs[i], int.Parse(repairs[i + 1])));
            }
        }

        public List<KeyValuePair<string, int>> Repairs { get; set; } = new List<KeyValuePair<string, int>>();
        public string Corps { get ; set ; }

        public override string ToString()
        {
            string result = "";

            result += $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
            result += $"\nCorps: {Corps}";
            result += "\nRepairs:";
            foreach (var repair in Repairs)
            {
                result += $"\n  Part Name: {repair.Key} Hours Worked: {repair.Value}";
            }

            return result;
        }
    }
}


