using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;

namespace ExInfernoInfinity.Core.Command
{
  public  class PrintCommand : Command
    {
        public PrintCommand(string[] data, ItemRepository itemRepository, ItemFactory itemFactory) : base(data, itemRepository, itemFactory)
        {
        }

        public override void Execute()
        {
            string itemName = Data[1];
            this.Repository.PrintItem(itemName);
        }
    }
}
