using System;
using System.Collections.Generic;
using System.Text;

namespace ExInfernoInfinity.Models.Items
{
   public class Knife : Item
    {
        private const int constMinDmg = 3;
        private const int constMaxDmg = 4;
        private const int constSocets = 2;

        public Knife(string rarity) : base(constMinDmg, constMaxDmg, constSocets, rarity)
        {
        }
    }
}
