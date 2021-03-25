using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05MordorsCruelPlan.Moods
{
    public abstract class Mood
    {
        private int happinessPoints;

        public Mood(int happinessPoints)
        {
            this.happinessPoints = happinessPoints;
        }
    }
}
