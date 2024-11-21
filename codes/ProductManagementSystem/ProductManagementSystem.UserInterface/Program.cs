using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagementSystem.BusinessComponents;
using ProductManagementSystem.Models;
using ProductManagementSystem.Repository;

IServiceProvider provider = CreateContainerAndRegsiterServices();
var businessManager = provider.GetService<IProductBusinessManager>();
var allProducts = businessManager.FetchAll();
allProducts.ForEach(product => Console.WriteLine(product.Name));


static IServiceProvider CreateContainerAndRegsiterServices()
{
    IServiceCollection container = new ServiceCollection();
    IServiceProvider provider = container
        .AddSingleton<IProductRepositoryManager, ProductRepository>()
        .AddSingleton<IProductBusinessManager, ProductBusinessManager>()
        .BuildServiceProvider();

    return provider;
}
//static IConfigurationRoot CreateConfiguration()
//{
//    var configBuilder = new ConfigurationBuilder();
//    configBuilder
//        .SetBasePath(Directory.GetCurrentDirectory())
//        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
//    IConfigurationRoot configuration = configBuilder.Build();
//    return configuration;
//}