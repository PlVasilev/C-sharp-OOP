using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;
using ExInfernoInfinity.Models.Gems;
using ExInfernoInfinity.Models.Items;

namespace ExInfernoInfinity.Core.Command
{
   public class AddCommand : Command
    {
        public AddCommand(string[] data, ItemRepository itemRepository, ItemFactory itemFactory) : base(data, itemRepository, itemFactory)
        {
        }

        public override void Execute()
        {
            string itemName = Data[1];
            int indexOfGem = int.Parse(Data[2]);
            string gemType = Data[3].Split()[1];
            string gemQual = Data[3].Split()[0];
            Gem gemToAdd = ItemFactory.CreateGem(gemType,gemQual);
            this.Repository.AddGem(itemName,indexOfGem, gemToAdd);
        }
    }
}
