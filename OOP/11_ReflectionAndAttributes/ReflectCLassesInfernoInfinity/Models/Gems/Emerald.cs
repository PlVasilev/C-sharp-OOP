using System;
using System.Collections.Generic;
using System.Text;

namespace ExInfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        private const int baseStr = 1;
        private const int baseAgi = 4;
        private const int baseVit = 9;

        public Emerald(string quality) : base(baseStr, baseAgi, baseVit, quality)
        {
        }
    }
}
