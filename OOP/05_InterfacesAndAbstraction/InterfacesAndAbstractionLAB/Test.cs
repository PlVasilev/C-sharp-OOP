using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractionLAB
{
    public class Test : BaseTest, ITest, INewTest
    {
        public void NewTestMethod()
        {
            throw new NotImplementedException();
        }

        public void TestMethod(int number)
        {
            throw new NotImplementedException();
        }

        public string TestWriter()
        {
            throw new NotImplementedException();
        }
    }
}
