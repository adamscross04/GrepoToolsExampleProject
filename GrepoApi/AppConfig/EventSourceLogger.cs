using GrepoApi;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GrepoApi.AppConfig
{
    public class EventSourceLogger : ILogConsumer

    {
        private readonly ServiceEventSource eventSource;

        private readonly String pid;

        public EventSourceLogger()

        {
            eventSource = ServiceEventSource.Current;

            pid = Process.GetCurrentProcess().Id.ToString();
        }

        public void Log(Severity severity, LoggerType loggerType, String caller, String message,
            IPEndPoint myIpEndPoint, Exception exception, Int32 eventCode = 0)

        {
            if (exception != null)
                eventSource.Message($"[{severity}@{myIpEndPoint}@PID:{pid}] {message}\nException: {exception}");

            else eventSource.Message($"[{severity}@{myIpEndPoint}@PID:{pid}] {message}");
        }
    }
}
