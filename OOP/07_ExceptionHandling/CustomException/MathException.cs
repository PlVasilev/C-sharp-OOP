using System;
using System.Collections.Generic;
using System.Text;

namespace NameofCalculator
{
   public class MathException : Exception
    {
        public char Operator { get; set; }

        public MathException(string message, char opperator) : base(message)
        {
            Operator = opperator;
        }
    }
}
