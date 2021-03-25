using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05BorderControl
{
    public class Robot : Entree
    {
        public Robot(string id, string model) : base(id)
        {
            Model = model;
        }

        public string Model { get; set; }
    }
}
