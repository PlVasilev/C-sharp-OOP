using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MordorsCruelPlan
{
    public class Mushrooms : Food
    {
        private new const int PointsOfHappiness = -10;

        public Mushrooms() : base(PointsOfHappiness)
        {
        }
    }
}
