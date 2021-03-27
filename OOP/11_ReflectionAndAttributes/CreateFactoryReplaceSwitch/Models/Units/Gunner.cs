using System;
using System.Collections.Generic;
using System.Text;
using P03_BarraksWars.Models.Units;

namespace P03_BarraksWars.Models.Units
{
    public class Gunner : Unit
    {
        private const int DefaultHealth = 20;
        private const int DefaultDamage = 20;

        protected Gunner() : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
