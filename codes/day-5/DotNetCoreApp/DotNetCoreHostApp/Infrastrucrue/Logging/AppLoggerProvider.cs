using Microsoft.Extensions.Logging;

namespace DotNetCoreHostApp.Infrastrucrue.Logging
{
    public class AppLoggerProvider : ILoggerProvider
    {
        private AppLogger? _logger;
        private StreamWriter _writer;
        public AppLoggerProvider(StreamWriter _writer)
        {
            this._writer = _writer;
        }

        public ILogger CreateLogger(string categoryName)
        {
            _logger = new AppLogger(categoryName, _writer);
            return _logger;
        }

        public void Dispose()
        {
            _writer.Dispose();
        }
    }
}
