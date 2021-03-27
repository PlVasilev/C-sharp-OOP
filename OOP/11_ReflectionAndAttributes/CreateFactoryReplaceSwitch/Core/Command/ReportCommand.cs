using System;
using System.Collections.Generic;
using System.Text;
using P03_BarraksWars.Contracts;

namespace P03_BarraksWars.Core.Command
{
   public class ReportCommand : Command
    {




        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }

        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }
    }
}
