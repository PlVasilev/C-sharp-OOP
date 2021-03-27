using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;

namespace ExInfernoInfinity.Core.Command
{
   public class ENDCommand : Command
    {
        public ENDCommand(string[] data, ItemRepository itemRepository, ItemFactory itemFactory) : base(data, itemRepository, itemFactory)
        {
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
