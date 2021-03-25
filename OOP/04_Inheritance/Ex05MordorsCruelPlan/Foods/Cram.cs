using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MordorsCruelPlan
{
    public class Cram : Food
    {
        private new const int PointsOfHappiness = 2;

        public Cram() : base(PointsOfHappiness)
        {
        }
    }
}
