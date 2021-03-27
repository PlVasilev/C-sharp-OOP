using System;
using ExInfernoInfinity.Core;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;

namespace ExInfernoInfinity
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ItemRepository repository = new ItemRepository();
            ItemFactory unitFactory = new ItemFactory();
            CommandInterpreter commandInterpreter = new CommandInterpreter(repository, unitFactory);
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
