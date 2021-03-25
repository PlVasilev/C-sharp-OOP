using SOLIDLab.Loggers.Enums;

namespace SOLIDLab.Loggers
{
    using SOLIDLab.Appenders.Contracts;
    using Contracts;

    public class Logger : ILogger
    {
        private readonly IAppender _consoleAppender;
        private readonly IAppender _fileAppender;

        public Logger(IAppender consoleAppender)
        {
            _consoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
            :this(consoleAppender)
        {
            
            _fileAppender = fileAppender;
        }

        public void Error(string dateTime, string errorMessage)
        {
            AppendMessage(dateTime, ReportLevel.ERROR, errorMessage);   
        }

        public void Info(string dateTime, string infoMessage)
        {
            AppendMessage(dateTime, ReportLevel.INFO, infoMessage);
        }

        public void Fatal(string dateTime, string fatalMessage)
        {
            AppendMessage(dateTime, ReportLevel.FATAL, fatalMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            AppendMessage(dateTime, ReportLevel.CRITICAL, criticalMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            AppendMessage(dateTime, ReportLevel.WARNING, warningMessage);
        }

        private void AppendMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            _fileAppender?.Append(dateTime, reportLevel, message); // IF ITS NULL IT WONT EXECUTE APPEND METHOD ".?"
            _consoleAppender?.Append(dateTime, reportLevel, message);
        }
    }
}
