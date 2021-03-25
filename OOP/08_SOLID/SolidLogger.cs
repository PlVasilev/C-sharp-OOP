using SOLIDLab.Core;
using SOLIDLab.Core.Contracts;
using SOLIDLab.Loggers.Enums;

namespace SOLIDLab
{
    using Appenders;
    using Layouts;
    using Loggers;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            engine.Run();

        }
    }
}

