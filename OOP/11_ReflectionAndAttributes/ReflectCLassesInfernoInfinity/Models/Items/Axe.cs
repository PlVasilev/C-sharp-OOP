using System;
using System.Collections.Generic;
using System.Text;

namespace ExInfernoInfinity.Models.Items
{
    public class Axe : Item
    {
        private const int constMinDmg = 5;
        private const int constMaxDmg = 10;
        private const int constSocets = 4;

        public Axe(string rarity) : base(constMinDmg, constMaxDmg, constSocets, rarity)
        {
        }
    }
}
