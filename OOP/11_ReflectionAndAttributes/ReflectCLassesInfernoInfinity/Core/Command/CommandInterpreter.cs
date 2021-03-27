using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ExInfernoInfinity.Contracts;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;

namespace ExInfernoInfinity
{
    public class CommandInterpreter
    {
        private ItemRepository itemRepository;
        private ItemFactory itemFactory;


        public CommandInterpreter()
        {
        }


        public CommandInterpreter(ItemRepository itemRepository, ItemFactory itemFactory)
        {
            this.itemFactory = itemFactory;
            this.itemRepository = itemRepository;
        }

        public void InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == commandName.ToLower() + "command");
            IExecutable executable = (IExecutable)Activator.CreateInstance(type, new object[] { data, this.itemRepository, this.itemFactory });
            executable.Execute();
        }
    }
}
