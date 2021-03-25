using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04Telephony
{
    public class SmartPhone : ICall, IBrawse
    {
  

        public List<string> Numbers { get; set; } = new List<string>();
        public List<string> Sites { get; set; } = new List<string>();
    
        
        public List<string> Brawse()
        {
            return Sites;
        }

        public List<string> Call()
        {
            return Numbers;
        }
    }
}
