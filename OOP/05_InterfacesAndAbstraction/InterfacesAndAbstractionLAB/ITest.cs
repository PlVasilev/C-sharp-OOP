using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractionLAB
{/// <summary>
/// ITest
/// </summary>
    public interface ITest // implementation of thhe method is done in the class
    {
        /// <summary>
        /// This is a test method
        /// </summary>
        /// <param name="number">This is very important number</param>
        void TestMethod(int number); // we should use every time /// so we can make documentation for the code

        /// <summary>
        /// Writer Method
        /// </summary>
        /// <returns>Very Nice String</returns>
        string TestWriter();
    }
}
