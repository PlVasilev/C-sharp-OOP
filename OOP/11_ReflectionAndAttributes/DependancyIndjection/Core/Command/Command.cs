namespace DependancyInjection.Core.Command
{
    using _03BarracksFactory.Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;


        protected Command(string[] data)
        {
            this.Data = data;
        }

        public string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        public abstract string Execute();

    }
}
