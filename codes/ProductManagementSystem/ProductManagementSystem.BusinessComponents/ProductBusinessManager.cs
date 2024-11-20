using ProductManagementSystem.Models;
using ProductManagementSystem.Repository;

namespace ProductManagementSystem.BusinessComponents
{
    public class ProductBusinessManager : IProductBusinessManager
    {
        private IProductRepositoryManager repositoryManager;
        public ProductBusinessManager(IProductRepositoryManager manager)
        {
            //tight coupling
            repositoryManager = new ProductRepository();
            //repositoryManager = manager;
        }
        public Product Fetch(int id)
        {
            return repositoryManager.Get(id);
        }

        public List<Product> FetchAll()
        {
            var all = repositoryManager.GetAll();
            all.Sort();
            return all;
        }

        public List<Product> FilterProducts(string productName)
        {
            if (productName == null || productName == string.Empty)
                throw new ArgumentNullException("product name is either null or empty");

            return repositoryManager.FilterProducts(productName);
        }

        public Product Insert(Product entity)
        {
            return entity == null ? throw new ArgumentNullException("product object is null") : repositoryManager.Add(entity);
        }

        public Product Modify(int id, Product entity)
        {
            return entity == null ? throw new ArgumentNullException("product object is null") : repositoryManager.Update(id, entity);
        }

        public Product Remove(int id)
        {
            return repositoryManager.Delete(id);
        }
    }
}
