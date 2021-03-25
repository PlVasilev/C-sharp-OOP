using Ex08MilitaryElite.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
         List<Soldier> Privates { get; set; }
    }
}
