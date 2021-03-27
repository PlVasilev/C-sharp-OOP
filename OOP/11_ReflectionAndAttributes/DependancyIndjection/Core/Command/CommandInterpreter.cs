using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using _03BarracksFactory.Contracts;

namespace DependancyInjection.Core.Command
{
   public class CommandInterpreter : ICommandInterpreter
   {
       private IServiceProvider serviceProvider;
      

        public CommandInterpreter()
        {
        }

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;  
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().FirstOrDefault(x => x.Name.ToLower() == commandName + "command");

            FieldInfo[] fieldsToInject = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute))).ToArray();
            // вземи там където има инджект атрибут

            object[] indjectedArguments = fieldsToInject.Select(f => serviceProvider.GetService(f.FieldType)).ToArray();
                // за всяко поле което искаш да инджектнеш бръкни във сървиз провайдера и вземи сервиз

            object[] commandArgs = new object[]{data}.Concat(indjectedArguments).ToArray();

            IExecutable executable = (IExecutable) Activator.CreateInstance(type, commandArgs);
            return executable;
        }
    }
}
