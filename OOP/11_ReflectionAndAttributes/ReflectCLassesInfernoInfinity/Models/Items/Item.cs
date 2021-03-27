namespace ExInfernoInfinity.Models.Items
{
    using Gems;

    public abstract class Item
    {
        protected Item(int minDmg, int maxDmg, int socets, string rarity)
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            Socets = new Gem[socets];
            switch (rarity)
            {
                case "Uncommon":
                    MinDmg *= 2;
                    MaxDmg *= 2;
                    break;
                case "Rare":
                    MinDmg *= 3;
                    MaxDmg *= 3;
                    break;
                case "Epic":
                    MinDmg *= 5;
                    MaxDmg *= 5;
                    break;
                case "Common":
                    break;
            }
        }

        public int MinDmg { get; private set; }
        public int MaxDmg { get; private set; }
        public Gem[] Socets { get; private set; }


    }
}
