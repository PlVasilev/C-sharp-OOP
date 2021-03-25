using System.Collections.Generic;
using SOLIDLab.Appenders.Contracts;

namespace SOLIDLab.Core
{
    using System;
    using Contracts;

    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
               this.commandInterpreter.AddAppender(inputArgs);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries); 

                commandInterpreter.AddMessage(inputArgs);

                input = Console.ReadLine();
            }

            commandInterpreter.PrintInfo();
        }
    }
}
