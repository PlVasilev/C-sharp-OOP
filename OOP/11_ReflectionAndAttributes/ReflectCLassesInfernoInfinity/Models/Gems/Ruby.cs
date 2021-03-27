using System;
using System.Collections.Generic;
using System.Text;

namespace ExInfernoInfinity.Models.Gems
{
   public class Ruby : Gem
   {
       private const int baseStr = 7;
       private const int baseAgi = 2;
       private const int baseVit = 5;

        public Ruby(string quality) : base(baseStr, baseAgi, baseVit, quality)
        {
        }
    }
}
