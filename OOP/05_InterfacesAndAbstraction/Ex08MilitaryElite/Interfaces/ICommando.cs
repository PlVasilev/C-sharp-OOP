using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Interfaces
{
    interface ICommando : ISpecialisedSoldier
    {
        List<KeyValuePair<string, string>> Misions { get; set; }
    }
}
