using System;
using System.Linq;
using ExInfernoInfinity.Models.Gems;

namespace ExInfernoInfinity.Data
{
    using System.Collections.Generic;
    using Models.Items;

    public class ItemRepository
    {
        private Dictionary<string, Item> items;

        public ItemRepository()
        {
            items = new Dictionary<string, Item>();
        }

        public void AddItem(string itemName, Item item)
        {
            if (!this.items.ContainsKey(itemName))
            {
                this.items.Add(itemName, null);
            }

            this.items[itemName] = item;
        }

        public void AddGem(string itemName, int index, Gem gem)
        {
            Item currentItem = GetItem(itemName);
            if (index >= 0 && index < currentItem.Socets.Length)
            {
                currentItem.Socets[index] = gem;
            }
        }

        public void RemoveGem(string itemName, int index)
        {
            Item currentItem = GetItem(itemName);
            if (index >= 0 && index < currentItem.Socets.Length)
            {
                currentItem.Socets[index] = null;
            }
        }

        public void PrintItem(string itemName)
        {
            Item currentItem = GetItem(itemName);
            int strenght = 0;
            int agility = 0;
            int vitality = 0;

            foreach (var gem in currentItem.Socets)
            {
                if (gem != null)
                {
                    strenght += gem.Strength;
                    agility += gem.Agility;
                    vitality += gem.Vitality;
                }        
            }

            int minDmg = currentItem.MinDmg + strenght * 2 + agility;
            int maxDmg = currentItem.MaxDmg + strenght * 3 + agility * 4;

            Console.WriteLine($"{itemName}: {minDmg}-{maxDmg} Damage, +{strenght} Strength, +{agility} Agility, +{vitality} Vitality");
        }

        private Item GetItem(string name)
        {
            return items.FirstOrDefault(x => x.Key == name).Value;
        }
    }
}
