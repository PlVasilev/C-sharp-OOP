using System;
using System.Collections.Generic;
using System.Text;
using P03_BarraksWars.Contracts;

namespace P03_BarraksWars.Core.Command
{
    public class AddCommand : Command
    {

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }

        public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
        {
        }
    }
}
