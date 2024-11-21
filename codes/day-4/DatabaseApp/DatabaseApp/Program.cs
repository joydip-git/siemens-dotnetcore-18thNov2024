using DatabaseApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


IConfigurationRoot configuration = CreateConfiguration();
DbUtility.Configuration = configuration;

//Console.WriteLine(configuration["Settings1"]);
//Console.WriteLine(configuration.GetSection("Settings1").Value);
//Console.WriteLine(configuration["AppSettings:Settings2"]);
//Console.WriteLine(configuration.GetConnectionString("SiemensConStr"));

//CategoryRepository repository = new();
var provider = CreateContainerAndRegsiterServices();
var business = provider.GetService<IBusinessService<Category>>();
business?.GetAll()
    .ForEach(c => Console.WriteLine(c.Name + " " + c.Id));

//IRepository<Category>? repository = provider.GetService<IRepository<Category>>();

//IRepository<Category>? repository1 = provider.GetService<IRepository<Category>>();

//repository?.FetchData()
//    .ForEach(c => Console.WriteLine(c.Name + " " + c.Id));
//Category category = new Category { Name="Book"};
//repository.AddData(category);


/*
repository.DeleteData(103);
*/

static IServiceProvider CreateContainerAndRegsiterServices()
{
    IServiceCollection container = new ServiceCollection();
    IServiceProvider provider = container
        .AddSingleton<IBusinessService<Category>, BusinessService>()
        .AddSingleton<IRepository<Category>, CategoryRepository>()
        .BuildServiceProvider();
    Console.WriteLine("created provider");
    return provider;
}
static IConfigurationRoot CreateConfiguration()
{
    var configBuilder = new ConfigurationBuilder();
    configBuilder
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    return configBuilder.Build();
}

/*
class Container
{
    public Container AddSingleton<TInterface, TClass>()
    {
        var type = typeof(TClass);
        var typeInterface = typeof(TInterface);
        bool present = type.GetInterfaces().Any(t => t.Name == typeInterface.Name);
        if(!present)
            
    }
    public TInterface GetService<TInterface>()
    {

    }
}
*/
public interface IBusinessService<T> {
    List<T> GetAll();
}
public class BusinessService : IBusinessService<Category>
{
    private IRepository<Category>? repository;
    public BusinessService(IRepository<Category> repository)
    {
        this.repository = repository;
    }

    public List<Category> GetAll()
    {
        return repository.FetchData();
    }
    //public IRepository<Category> Repository { get; set; }
}






