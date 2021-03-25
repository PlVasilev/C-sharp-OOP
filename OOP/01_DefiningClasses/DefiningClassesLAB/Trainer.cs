using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public Trainer(string name, Pokemon pokemon)
        {
            Name = name;
            Pokemons.Add(pokemon);
        }
    }
}
