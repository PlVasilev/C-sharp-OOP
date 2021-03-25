using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
