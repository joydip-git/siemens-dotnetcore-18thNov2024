using Microsoft.Extensions.Logging;

namespace DotNetCoreHostApp.Infrastrucrue.Logging
{
    public class AppLogger : ILogger
    {
        private readonly string _categoyrName;
        private readonly StreamWriter _writer;

        public AppLogger(string categoyrName, StreamWriter writer)
        {
            _categoyrName = categoyrName;
            _writer = writer;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= LogLevel.Information;
        }

        public void Log<TState>(
            LogLevel logLevel, 
            EventId eventId, 
            TState state, 
            Exception? exception, 
            Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel)) return;

            var message = formatter(state, exception);
            _writer.WriteLine($"[Category:{_categoyrName}],[Message={message}]");
            _writer.Flush();

            //staticclass.staticmethod(
        }
    }
}
