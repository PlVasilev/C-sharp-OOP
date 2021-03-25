using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : Car, IElectricCar
    {
        private Battery battery;

        public Battery Battery { get => battery ; set => battery = value; }

        public override string Stop()
        {
            return "Tesla Stoped!";
        }

        public override string Start()
        {
            return "Tesla Started!";
        }
    }
}
