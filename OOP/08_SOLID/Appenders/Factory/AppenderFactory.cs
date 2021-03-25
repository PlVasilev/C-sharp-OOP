using System;
using System.Collections.Generic;
using System.Text;
using SOLIDLab.Appenders.Contracts;
using SOLIDLab.Appenders.Factory.Contracts;
using SOLIDLab.Layouts.Contracts;
using SOLIDLab.Loggers;

namespace SOLIDLab.Appenders.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeAsLowerCase = type.ToLower();
            switch (typeAsLowerCase)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid Appender Type!");
            }
        }
    }
}
