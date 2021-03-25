using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWIthAbstractionLAB
{
    public class ClassArch
    {
        private readonly int num = 8; // this field is variable initializer

        public int MyProperty { get; set; } = 0; // initialization
        public List<int> numbers { get; set; } = new List<int>(); // vs2017

        public List<int> numbers1 { get; set; } // Older VS
        public ClassArch()
        {
            numbers1 = new List<int>();
        }

        public ClassArch(int number) : this() // we call the first constructor
        {
            numbers1.Add(number);
        }

        public ClassArch(int number, int myprop) : this(number) // we call the second constructor
        {
            MyProperty = myprop;
        }

        private void Test()
        {
           // num = 5;
        }
    }
}
