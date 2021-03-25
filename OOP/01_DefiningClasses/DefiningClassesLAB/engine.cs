using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        //public int Speed { get; set; }
        //public int Power { get; set; }
        //
        //public Engine(int speed, int power)
        //{
        //    Speed = speed;
        //    Power = power;
        //}

        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }


        public Engine(string model, string power, string displacement)
        {
            Model = model;
            Power = power;
            int displ = 0;
            if (int.TryParse(displacement, out displ))
            {
                Displacement = displacement;
                Efficiency = "n/a";
            }
            else
            {
                Displacement = "n/a";
                Efficiency = displacement;
            }

        }


        public Engine(string model, string power, string displacemnet, string efficienty)
        {
            Model = model;
            Power = power;
            Displacement = displacemnet;
            Efficiency = efficienty;
        }
    }
}
