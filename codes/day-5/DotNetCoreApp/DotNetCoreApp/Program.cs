using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

Console.WriteLine("Hello, World!");

Action<SimpleConsoleFormatterOptions> formatterBuilder = (options) =>
{
    options.SingleLine = true;
    options.TimestampFormat = "HH:mm:ss";
};
Action<ILoggingBuilder> loggerBuilder =
    (options) =>
    {
        options.AddSimpleConsole(formatterBuilder);
        options.AddFilter("Info", LogLevel.Information);
        options.AddFilter("Warning", LogLevel.Warning);
        options.AddFilter("Debug", LogLevel.Debug);
        options.AddFilter("Error", LogLevel.Error);
    };

//1. DI configuration

IServiceCollection container = new ServiceCollection();
//container.AddSingleton();
//container.AddLogging(loggerBuilder);
IServiceProvider provider = container.BuildServiceProvider();

//2. Configuration configuration
IConfigurationBuilder configBuilder = new ConfigurationBuilder();
configBuilder.SetBasePath(Directory.GetCurrentDirectory());
//configBuilder.AddJsonFile("");
IConfiguration configuration = configBuilder.Build();

//3. Logging configuration
ILoggerFactory loggerFactory = LoggerFactory.Create(loggerBuilder);
ILogger<Program> programLogger = loggerFactory.CreateLogger<Program>();


programLogger.LogInformation("Logging Info");
programLogger.LogError("Logging error");
programLogger.LogDebug("Logging debug");

Console.ReadKey();
