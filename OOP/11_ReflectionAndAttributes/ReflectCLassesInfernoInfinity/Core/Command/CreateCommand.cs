using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;
using ExInfernoInfinity.Models.Items;

namespace ExInfernoInfinity.Core.Command
{
   public class CreateCommand : Command
    {
        public CreateCommand(string[] data, ItemRepository repository, ItemFactory itemFactory) : base(data, repository, itemFactory)
        {
        }

        public override void Execute()
        {
            string itemType = Data[1].Split()[1];
            string itemQual = Data[1].Split()[0];
            string itemName = Data[2];
            Item itemToCreate = ItemFactory.CreateItem(itemType,itemQual);
            this.Repository.AddItem(itemName, itemToCreate);
        }

    }
}
