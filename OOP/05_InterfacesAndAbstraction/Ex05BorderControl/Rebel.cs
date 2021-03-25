using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05BorderControl
{
    public class Rebel : Bialogical, IBuyer
    {
        public Rebel(string name) : base(name)
        {
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
