namespace ExInfernoInfinity.Models.Gems
{
    public abstract class Gem
    {
        protected Gem(int strength,int agility,int vitality,string quality)
        {
            Strength = strength;
            Agility = agility;
            Vitality = vitality;
            switch (quality)
            {
                case "Regular":
                    Strength += 2;
                    Agility += 2;
                    Vitality += 2;
                    break;
                case "Perfect":
                    Strength += 5;
                    Agility += 5;
                    Vitality += 5;
                    break;
                case "Flawless":
                    Strength += 10;
                    Agility += 10;
                    Vitality += 10;
                    break;
                case "Chipped":
                    Strength += 1;
                    Agility += 1;
                    Vitality += 1;
                    break;
            }
        }
        public int Strength { get; private set; }
        public int Agility { get; private set; }
        public int Vitality { get; private set; }

    }
}
