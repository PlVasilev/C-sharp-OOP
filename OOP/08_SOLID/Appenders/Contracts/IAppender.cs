using SOLIDLab.Loggers.Enums;

namespace SOLIDLab.Appenders.Contracts
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        int MessagesCount { get; }

        void Append(string dateTime, ReportLevel errorLevel, string message);
    }
}
