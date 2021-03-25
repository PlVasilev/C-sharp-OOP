using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    class MutableExample
    {
        private readonly int number;
        private readonly List<int> numbers = new List<int>();


        public List<int> Numbers
        {
            get
            {
                return numbers;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

        }

        private void SerNumber()
        {
          //  number = 6; it is readonly we we can not change it even in the class
        }
    }
}
