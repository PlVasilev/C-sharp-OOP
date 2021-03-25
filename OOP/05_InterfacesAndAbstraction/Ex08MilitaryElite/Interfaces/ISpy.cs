using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Interfaces
{
   public interface ISpy : ISoldier
    {
        int CodeNumber { get; set; }
    }
}
