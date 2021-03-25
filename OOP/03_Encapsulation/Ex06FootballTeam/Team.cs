using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex06FootballTeam
{
    class Team
    {
        public string Name { get; private set; }
        private List<Player> Players { get; set; } = new List<Player>();

        public Team(string name)
        {
            Name = name;
        }

        public double Rating()
        {
            if (Players.Count > 0)
            {
                return Players.Sum(x => x.Stats) / Players.Count;
            }
            return 0;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            if (!Players.Any(x => x.Name == name))
            {
                throw new ArgumentException($"Player {name} is not in {Name} team.");
            }
            int index = Players.FindIndex(x => x.Name == name);
            Players.RemoveAt(index);
        }
    }
}
