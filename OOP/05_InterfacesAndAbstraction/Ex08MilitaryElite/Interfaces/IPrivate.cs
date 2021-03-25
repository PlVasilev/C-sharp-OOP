using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Interfaces
{
    public interface IPrivate : ISoldier
    {
         decimal Salary { get; set; }
    }
}
