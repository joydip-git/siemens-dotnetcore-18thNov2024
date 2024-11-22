using DataServiceLibrary;
using DotNetCoreHostApp.Infrastrucrue.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using (StreamWriter writer = new("logfile.txt", append: true))
{
    var host = CreateHost(args, writer);
    //host.Start();
    var serviceObject = host.Services.GetService<IDataService<string>>();
    Console.WriteLine(serviceObject?.GetData());

}

Console.WriteLine("press any key to terminate...");
Console.ReadLine();

static IHost CreateHost(string[] args, StreamWriter writer)
{
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
            options.AddProvider(new AppLoggerProvider(writer));
        };

    IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);
    hostBuilder
        .ConfigureHostConfiguration(
        configBuilder =>
        {
            configBuilder
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        })
        .ConfigureLogging(loggerBuilder)
        .ConfigureServices(
        container =>
        {
            container.AddSingleton<IDataService<string>, DataService>();
        }
        );
    return hostBuilder.Build();
}








