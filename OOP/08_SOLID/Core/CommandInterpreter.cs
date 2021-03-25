using System.Collections.Generic;
using SOLIDLab.Appenders.Contracts;
using SOLIDLab.Appenders.Factory;
using SOLIDLab.Appenders.Factory.Contracts;
using SOLIDLab.Layouts.Contracts;
using SOLIDLab.Layouts.Factory;
using SOLIDLab.Layouts.Factory.Contracts;
using SOLIDLab.Loggers.Enums;

namespace SOLIDLab.Core
{
    using System;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            appenders = new List<IAppender>();
            appenderFactory = new AppenderFactory();
            layoutFactory = new LayoutFactory();

        }

        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2],true); // ignor case sensitivity
            }

            ILayout layout = layoutFactory.CreateLayout(layoutType);
            IAppender appender = appenderFactory.CreateAppender(appenderType, layout);
            appender.ReportLevel = reportLevel;

            appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0],true); // ignor case sensitivity
            string dateTime = args[1];
            string message = args[2];

            foreach (var appender in appenders)
            {
                appender.Append(dateTime,reportLevel,message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");
            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
