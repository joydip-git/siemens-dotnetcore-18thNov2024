// See https://aka.ms/new-console-template for more information
using EfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureHostConfiguration(
    (configBuilder) =>
    {
        configBuilder
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    }
    )
    .ConfigureServices(container =>
    {
        container
        .AddDbContext<SiemensDbContext>(
            builder =>
            {
                builder.UseSqlServer(@"server=.\sqlexpress;database=siemensdatabase;user id=sa;password=sqlserver2024;TrustServerCertificate=True");
                //var configuration = t
                //builder.UseSqlServer(configuration.GetConnectionString("SiemensConStr"));

            }
            );
    }
    ).Build();

using var context = host.Services.GetService<SiemensDbContext>();
//var products = context.Products;

//fetch all
//products.ToList().ForEach(p => Console.WriteLine(p.Name));

//add
context.Categories.Add(new Category { Name = "pencil" });
int res = context.SaveChanges();
context.Categories.ToList().ForEach(p => Console.WriteLine(p.Name));

//delete
//products.Remove(null);
//context.SaveChanges();

//update
//products.Update(null);
//context.SaveChanges();
