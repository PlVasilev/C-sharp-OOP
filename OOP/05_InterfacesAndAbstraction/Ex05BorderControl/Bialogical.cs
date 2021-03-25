using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05BorderControl
{
   public abstract class Bialogical 
    {
        public Bialogical(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Food { get; set; } = 0;

    }
}
