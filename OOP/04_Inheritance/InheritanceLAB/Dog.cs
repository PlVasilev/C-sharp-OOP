using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLAB
{
    public class Dog : Animal // SEALED from nоwone this Class can NOT be INHARITED
    {
        public Dog(string name)
        {
            Name = name;
        }

        private void Bark()
        {

        }

        public override sealed void Move() // We stop the OverRIDE from here
        {
            Console.WriteLine("Run");
        }
    }
}
