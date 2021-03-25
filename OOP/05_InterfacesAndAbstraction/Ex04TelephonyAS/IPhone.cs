using System;
using System.Collections.Generic;
using System.Text;

namespace _04TelephonyAUT
{
    public interface IPhone
    {
        string Model { get; }

        string Call(string phoneNumber);
    }
}
