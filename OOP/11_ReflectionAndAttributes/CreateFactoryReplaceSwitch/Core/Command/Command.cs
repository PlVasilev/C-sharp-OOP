 namespace P03_BarraksWars.Core.Command
{
    using P03_BarraksWars.Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
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

        public string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        public abstract string Execute();

    }
}
