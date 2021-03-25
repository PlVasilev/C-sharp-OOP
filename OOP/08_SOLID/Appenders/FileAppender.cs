using System.IO;
using SOLIDLab.Layouts.Contracts;
using SOLIDLab.Loggers.Contracts;
using SOLIDLab.Loggers.Enums;

namespace SOLIDLab.Appenders
{
    using Contracts;

    public class FileAppender : Appender
    {
        private const string Path = "../../../log.txt"; 
        private readonly ILogFile _logFile;

        public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
        {
            _logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel errorLevel, string message)
        {
            if (errorLevel >= ReportLevel)
            {
                MessagesCount++;
                string content = string.Format(Layout.Format, dateTime, errorLevel, message) + "\n";
                _logFile.Write(content);
                File.AppendAllText(Path, content);
            }     
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, " +
                   $"Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {MessagesCount}, File size: {_logFile.Size}";
        }
    }
}
