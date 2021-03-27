using System;
using System.Collections.Generic;
using System.Text;
using P03_BarraksWars.Contracts;

namespace P03_BarraksWars.Core.Command
{
   public class RetireCommand : Command
    {

        public override string Execute()
        {
            try
            {
                this.Repository.RemoveUnit(Data[1]);
                return $"{this.Data[1]} retired!";
            }
            catch (InvalidOperationException e)
            {
                return e.Message;
            }
            
        }

        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }
    }
}
