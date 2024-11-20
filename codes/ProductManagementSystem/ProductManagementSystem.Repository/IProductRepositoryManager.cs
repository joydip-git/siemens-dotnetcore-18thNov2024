using ProductManagementSystem.Models;

namespace ProductManagementSystem.Repository
{
    public interface IProductRepositoryManager:IRepositoryManager<int,Product>
    {
        List<Product> FilterProducts(string productName);
    }
}
