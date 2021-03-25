using System;
using System.Collections.Generic;
using System.Text;
using Ex08MilitaryElite.Interfaces;

namespace Ex08MilitaryElite.Classes
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Soldier> privates, string[] privatesId)
            : base(id, firstName, lastName, salary)
        {
            for (int i = 0; i < privatesId.Length; i++)
            {
                foreach (var privatee in privates)
                {
                    if (privatee.Id == privatesId[i])
                    {
                        Privates.Add(privatee);
                    }
                }
            }
        }

        public List<Soldier> Privates { get; set; } = new List<Soldier>();

        public override string ToString()
        {
            string result = "";

            result += $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
            result += "\nPrivates:";
            foreach (Private privatee in Privates)
            {
                result += $"\n  Name: {privatee.FirstName} {privatee.LastName} Id: {privatee.Id} Salary: {privatee.Salary:f2} ";
            }

            return result;
        }
    }
}


