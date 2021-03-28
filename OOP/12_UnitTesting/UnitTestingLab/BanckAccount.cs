using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace UnitTestingLab
{
   public class BanckAccount
    {
        public int Amount { get; set; }

        public void Deposit(int sum)
        {
            Amount += sum;
        }
      
    }
}
