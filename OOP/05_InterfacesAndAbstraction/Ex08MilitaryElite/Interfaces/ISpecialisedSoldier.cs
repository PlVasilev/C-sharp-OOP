using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
         string Corps { get; set; }
    }
}
