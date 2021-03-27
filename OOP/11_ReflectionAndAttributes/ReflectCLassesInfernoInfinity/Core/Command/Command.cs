using System;
using System.Collections.Generic;
using System.Text;
using ExInfernoInfinity.Contracts;
using ExInfernoInfinity.Core.Factories;
using ExInfernoInfinity.Data;

namespace ExInfernoInfinity.Core.Command
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private ItemRepository itemRepository;
        private ItemFactory itemFactory;

        protected Command(string[] data, ItemRepository itemRepository, ItemFactory itemFactory)
        {
            this.Data = data;
            Repository = itemRepository;
            ItemFactory = itemFactory;
        }

        public ItemFactory ItemFactory
        {
            get { return itemFactory; }
            private set { itemFactory = value; }
        }

        public ItemRepository Repository
        {
            get { return itemRepository; }
            private set { itemRepository = value; }
        }

        public string[] Data
        {
            get { return data; }
            private set { data = value; }
        }

        public abstract void Execute();

    }
}