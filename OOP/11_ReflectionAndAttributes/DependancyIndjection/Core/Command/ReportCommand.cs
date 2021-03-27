using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace DependancyInjection.Core.Command
{
   public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data, IRepository repository) : base(data)
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
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
