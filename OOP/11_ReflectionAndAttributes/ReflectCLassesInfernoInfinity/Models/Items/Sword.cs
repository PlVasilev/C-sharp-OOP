using System;
using System.Collections.Generic;
using System.Text;

namespace ExInfernoInfinity.Models.Items
{
   public class Sword : Item
    {
        private const int constMinDmg = 4;
        private const int constMaxDmg = 6;
        private const int constSocets = 3;

        public Sword(string rarity) : base(constMinDmg, constMaxDmg, constSocets, rarity)
        {
        }
    }
}
