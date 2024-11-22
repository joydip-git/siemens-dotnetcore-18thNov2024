using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DataServiceLibrary
{
    public class DataService : IDataService<string>
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DataService> _logger;

        public DataService(IConfiguration configuration, ILogger<DataService> logger)
        {
            this._configuration = configuration;
            this._logger = logger;
        }
        public string GetData()
        {
            var data = _configuration.GetSection("data").Value;
            _logger.LogInformation("logged=> " + data);
            return "file " + data;
        }
    }
}
