using System.Linq;
using SOLIDLab.Loggers.Contracts;

namespace SOLIDLab.Loggers
{
  public  class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Write(string message)
        {
            Size += message.Where(x => (x >= 65 && x <= 90) || (x >= 97 && x <= 122)).Sum(x => x);
        }     
    }
}
