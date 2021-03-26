using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsLAB
{
   public class Calculator
    {
        public int SUm(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }
    }
}
