using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03Ferrari
{
    public class Ferrari : IFerrari
    {
        public const string model = "488-Spider";

        public Ferrari(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string PushBreaks()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
          return "Zadu6avam sA!";
        }
    }
}
