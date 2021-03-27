using System;
using System.Collections.Generic;
using System.Text;
using P03_BarraksWars.Models.Units;

namespace P03_BarraksWars.Models.Units
{
    public class Horseman : Unit
    {
        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        protected Horseman() : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
