using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05BorderControl
{
    public class Citizen : Bialogical, IBuyer
    {
        public Citizen(string name) : base(name)
        {
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
