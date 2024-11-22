using Microsoft.EntityFrameworkCore;
using ProductServiceAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SiemensDbContext>(
    (options) =>
    {
        var conStr = builder.Configuration.GetConnectionString("SiemensConStr");
        options.UseSqlServer(conStr);
    }
    );
builder.Services.AddControllers();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();

//await app.RunAsync();
app.Run();
Console.ReadLine();
