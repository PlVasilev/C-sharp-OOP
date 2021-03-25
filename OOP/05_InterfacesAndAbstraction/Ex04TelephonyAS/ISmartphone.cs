using System;
using System.Collections.Generic;
using System.Text;

namespace _04TelephonyAUT
{
    public interface ISmartphone : IPhone
    {
        string Browse(string url);
    }
}
