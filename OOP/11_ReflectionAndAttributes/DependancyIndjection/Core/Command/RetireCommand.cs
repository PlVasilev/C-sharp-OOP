using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace DependancyInjection.Core.Command
{
   public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository) : base(data)
        {
            Repository = repository;
        }

        public IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

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
    }
}
