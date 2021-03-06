using System;
using System.IO;
using PartCover.Framework.Data;

namespace PartCover.Framework
{
    public partial class Connector
    {
        readonly PartCoverConnector2Class connector = new PartCoverConnector2Class();
        readonly ReportReceiver receiver = new ReportReceiver(new SymbolReaderFactory());
        readonly ConnectorActionCallback actionCallback;

        EventHandler<StatusEventArgs> statusMessageReceived;
        public event EventHandler<StatusEventArgs> StatusMessageReceived
        {
            add { statusMessageReceived += value; }
            remove { statusMessageReceived -= value; }
        }

        EventHandler<LogEntryEventArgs> logEntryReceived;
        public event EventHandler<LogEntryEventArgs> LogEntryReceived
        {
            add { logEntryReceived += value; }
            remove { logEntryReceived -= value; }
        }

        public Connector()
        {
            actionCallback = new ConnectorActionCallback(this);
        }

        public Report Report { get; private set; }
        public SessionRunOptions Options { get; set; }

        public void StartTarget()
        {
            var options = Options;
            if (options == null)
                throw new InvalidOperationException("Options are not set");

            connector.StatusCallback = actionCallback;

            // set mode
            connector.EnableOption(ProfilerMode.COUNT_COVERAGE);

            ExcludeItem("[mscorlib]*");
            ExcludeItem("[System*]*");

            if (options.TargetDirectory != null)
            {
                options.TargetDirectory = options.TargetDirectory.Trim();
            }
            if (options.TargetPath != null)
            {
                options.TargetPath = options.TargetPath.Trim();
            }
            if (options.TargetArguments != null)
            {
                options.TargetArguments = options.TargetArguments.Trim();
            }
            if (string.IsNullOrEmpty(options.TargetDirectory))
            {
                options.TargetDirectory = Directory.GetCurrentDirectory();
            }

            // start target
            //  ProcessCallback.writeStatus("Start target");
            connector.StartTarget(
                options.TargetPath,
                options.TargetDirectory,
                options.TargetArguments,
                options.RedirectOutput);

            // wait results
            //ProcessCallback.writeStatus("Wait results");
            connector.WaitForResults(options.DelayClose);

            // walk results
            //ProcessCallback.writeStatus("Walk results");
            receiver.Report = new Report();
            connector.GetReport(receiver);

            Report = receiver.Report;

            if (options.FlattenDomains)
            {
                Report = new ReportDomainFlattener(Report).Flatten();
            }
        }

        public void CloseTarget()
        {
            //connector.CloseTarget();
        }

        public int? TargetExitCode
        {
            get
            {
                if (connector != null && connector.HasTargetExitCode)
                    return connector.TargetExitCode;
                return null;
            }
        }

        public int TargetProcessId
        {
            get
            {
                if (connector == null)
                    throw new InvalidOperationException("No connector available");
                return connector.ProcessId;
            }
        }

        public string DriverLogFile
        {
            get
            {
                if (connector == null)
                    throw new InvalidOperationException("No connector available");
                return connector.LogFilePath;
            }
        }

        internal void OnLogMessage(LogEntry message)
        {
            var eventHandler = logEntryReceived;
            if (eventHandler == null) { return; }
            eventHandler.Invoke(this, new LogEntryEventArgs(message));
        }

        internal void OnStatusReceive(string message)
        {
            var eventHandler = statusMessageReceived;
            if (eventHandler == null) { return; }
            eventHandler.Invoke(this, new StatusEventArgs(message));
        }
    }
}
