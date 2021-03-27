using System;
using System.Collections.Generic;
using System.Text;

namespace ExInfernoInfinity.Models.Gems
{
   public class Amethyst : Gem
    {
        private const int baseStr = 2;
        private const int baseAgi = 8;
        private const int baseVit = 4;

        public Amethyst(string quality) : base(baseStr, baseAgi, baseVit, quality)
        {
        }
    }
}
