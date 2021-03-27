﻿using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;

namespace DependancyInjection.Core.Command
{
   public class FightCommand : Command
    {


        public FightCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
