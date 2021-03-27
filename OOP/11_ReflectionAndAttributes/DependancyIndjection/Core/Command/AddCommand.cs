using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace DependancyInjection.Core.Command
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data)
        {
            Repository = repository;
            UnitFactory = unitFactory;
        }

        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            private set { unitFactory = value; }
        }

        public IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
