using System;
using System.Collections.Generic;
using System.Text;
using SOLIDLab.Appenders.Contracts;
using SOLIDLab.Layouts.Contracts;

namespace SOLIDLab.Appenders.Factory.Contracts
{
  public  interface IAppenderFactory
  {
      IAppender CreateAppender(string type, ILayout layout);
  }
}
