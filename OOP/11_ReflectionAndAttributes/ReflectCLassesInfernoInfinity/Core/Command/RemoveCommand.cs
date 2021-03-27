using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;

namespace ExInfernoInfinity.Core.Command
{
   public class RemoveCommand : Command
    {
        public RemoveCommand(string[] data, ItemRepository itemRepository, ItemFactory itemFactory) : base(data, itemRepository, itemFactory)
        {
        }

        public override void Execute()
        {
            string itemName = Data[1];
            int indexOfGem = int.Parse(Data[2]);
            this.Repository.RemoveGem(itemName, indexOfGem);
        }
    }
}
