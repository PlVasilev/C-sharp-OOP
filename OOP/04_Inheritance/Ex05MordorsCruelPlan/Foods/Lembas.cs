using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MordorsCruelPlan
{
    public class Lembas : Food
    {
        private new const int PointsOfHappiness = 3;

        public Lembas() : base(PointsOfHappiness)
        {
        }
    }
}
