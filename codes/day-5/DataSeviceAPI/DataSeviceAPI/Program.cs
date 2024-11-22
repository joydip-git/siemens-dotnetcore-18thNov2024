//web host builder
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//web host
WebApplication app = builder.Build();

app.MapGet("/hello", () => "Hello World!");
app.Start();
Console.WriteLine("ending...");
Console.ReadKey();

//app.Run();
