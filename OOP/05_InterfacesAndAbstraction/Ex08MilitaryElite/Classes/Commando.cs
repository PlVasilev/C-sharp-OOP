using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex08MilitaryElite.Interfaces;

namespace Ex08MilitaryElite.Classes
{
    public class Commando : Private, ISpecialisedSoldier
    {
        public Commando(string id, string firstName, string lastName, decimal salary,string corps, string[] missions) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
            for (int i = 0; i < missions.Length; i += 2)
            {
                if (missions[i + 1] == "inProgress" || missions[i + 1] == "Finished")
                {
                    Missions.Add(missions[i], missions[i + 1]);
                }
            }
        }

        public Dictionary<string, string> Missions { get; set; } = new Dictionary<string, string>();
        public string Corps { get; set; }

        public void CompleteMission(string mission)
        {
            foreach (var item in Missions)
            {
                if (item.Key == mission)
                {
                    Missions[mission] = "Finished";
                }
            }
        }

        public override string ToString()
        {
            string result = "";

            result += $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
            result += $"\nCorps: {Corps}";
            result += "\nMissions:";
            foreach (var mission in Missions)
            {
                result += $"\n  Code Name: {mission.Key} State: {mission.Value:f2}";
            }

            return result;
        }
    }
}
