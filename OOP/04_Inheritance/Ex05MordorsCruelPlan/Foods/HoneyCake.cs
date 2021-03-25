using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MordorsCruelPlan
{
    public class HoneyCake : Food
    {
        private new const int PointsOfHappiness = 5;

        public HoneyCake() : base(PointsOfHappiness)
        {
        }
    }
}
