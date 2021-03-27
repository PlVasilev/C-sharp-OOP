using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using P03_BarraksWars.Contracts;

namespace P03_BarraksWars.Core.Command
{
   public class CommandInterpreter : ICommandInterpreter
   {
       private IRepository repository;
       private IUnitFactory unitFactory;

        public CommandInterpreter()
        {
        }

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == commandName + "command");
            IExecutable executable = (IExecutable) Activator.CreateInstance(type, new object[] {data,this.repository,this.unitFactory });
            return executable;
        }
    }
}
