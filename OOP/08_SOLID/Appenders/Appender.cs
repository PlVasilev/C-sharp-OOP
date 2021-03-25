using System;
using System.Collections.Generic;
using System.Text;
using SOLIDLab.Appenders.Contracts;
using SOLIDLab.Layouts.Contracts;
using SOLIDLab.Loggers.Enums;

namespace SOLIDLab.Appenders
{
    public abstract class Appender : IAppender
    {

        protected Appender(ILayout layout)
        {
            Layout = layout;
        }

        protected ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public int MessagesCount { get; protected set; }
        public abstract void Append(string dateTime, ReportLevel errorLevel, string message);

        
    }
}
