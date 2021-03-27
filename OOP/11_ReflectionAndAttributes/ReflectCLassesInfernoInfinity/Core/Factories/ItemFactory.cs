using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ExInfernoInfinity.Models.Gems;
using ExInfernoInfinity.Models.Items;

namespace ExInfernoInfinity.Core.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string itemType,string itemQual)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); 

            Type type = assembly.GetTypes() 
                .FirstOrDefault(x => x.Name == itemType);

            Item instance = (Item)Activator.CreateInstance(type, new object[] { itemQual }); 
            return instance;

        }

        public Gem CreateGem(string gemType,string gemQual)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes()
                .FirstOrDefault(x => x.Name == gemType);

            Gem instance = (Gem)Activator.CreateInstance(type, new object[] { gemQual });
            return instance;
        }
    }
}
