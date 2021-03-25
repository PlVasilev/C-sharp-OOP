using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Interfaces
{
    interface IEngineer : ISpecialisedSoldier
    {
        List<KeyValuePair<string, int>> Repairs { get; set; }
    }
}
