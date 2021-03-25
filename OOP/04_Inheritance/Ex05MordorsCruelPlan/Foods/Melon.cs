using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MordorsCruelPlan
{
    public class Melon : Food
    {
        private new const int PointsOfHappiness = 1;

        public Melon() : base(PointsOfHappiness)
        {
        }
    }
}
