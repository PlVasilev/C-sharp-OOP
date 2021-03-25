using SOLIDLab.Loggers.Enums;

namespace SOLIDLab.Appenders
{
    using System;
    using Contracts;
    using SOLIDLab.Layouts.Contracts;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout) {}

        public override void Append(string dateTime, ReportLevel errorLevel, string message)
        {
            if (errorLevel >= ReportLevel)
            {
                MessagesCount++;
                Console.WriteLine(string.Format(Layout.Format, dateTime, errorLevel, message));
            }         
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {MessagesCount}";
        }

    }
}
