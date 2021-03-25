using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDLab.Loggers.Contracts
{
   public interface ILogFile
   {
       void Write(string message);

       int Size { get; }
   }
}
