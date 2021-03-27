using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Contracts;

namespace ExInfernoInfinity.Core
{
   public class Engine
   {
       private CommandInterpreter commandInterpreter;

       public Engine(CommandInterpreter commandInterpreter)
       {
           this.commandInterpreter = commandInterpreter;
       }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split(";",StringSplitOptions.RemoveEmptyEntries);
                    string commandName = data[0];
                    this.commandInterpreter.InterpretCommand(data, commandName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
