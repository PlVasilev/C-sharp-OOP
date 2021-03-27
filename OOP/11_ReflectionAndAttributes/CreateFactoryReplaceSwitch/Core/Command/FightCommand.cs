using System;
using System.Collections.Generic;
using System.Text;
using P03_BarraksWars.Contracts;

namespace P03_BarraksWars.Core.Command
{
   public class FightCommand : Command
    {
  

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }

        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }
    }
}
