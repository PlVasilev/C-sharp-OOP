using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06FootballTeam
{
    public class Player
    {
        private readonly double endurance;
        private readonly double sprint;
        private readonly double dribble;
        private readonly double passing;
        private readonly double shooting;

        public string Name { get; private set; }
        public double Stats { get; private set; }

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            Name = name;
            if (string.IsNullOrWhiteSpace(name) || name == string.Empty)
            {
                throw new ArgumentException("A name should not be empty.");
            }

            if (endurance < 0 || endurance > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            this.endurance = endurance;


            if (sprint < 0 || sprint > 100)
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            this.sprint = sprint;


            if (dribble < 0 || dribble > 100)
            {
                throw new ArgumentException("Dribble should be between 0 and 100.");
            }
            this.dribble = dribble;

            if (passing < 0 || passing > 100)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            this.passing = passing;

            if (shooting < 0 || shooting > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            this.shooting = shooting;

            Stats = Math.Round((endurance + sprint + dribble + passing + shooting) / 5);
        }
    }
}
