using ProductManagementSystem.Models;
using ProductManagementSystem.Storage;

namespace ProductManagementSystem.Repository
{
    public class ProductRepository : IProductRepositoryManager
    {
        public Product Add(Product entity)
        {
            var result = DataStorage.Products.Add(entity);
            return result ? entity : throw new Exception("could not add Product");
        }

        public Product Delete(int id)
        {
            var product = FindProduct(id);
            var result = DataStorage.Products.Remove(product);
            return result ? product : throw new Exception("could not delete Product");
        }

        public List<Product> FilterProducts(string productName)
        {
            return DataStorage.Products.Where(p => p.Name.Contains(productName, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public Product Get(int id)
        {
            return FindProduct(id);
        }

        public List<Product> GetAll()
        {
            return DataStorage.Products.ToList();
        }

        public Product Update(int id, Product entity)
        {
            var product = FindProduct(id);
            product.Price = entity.Price;
            product.Name = entity.Name;
            product.Description = entity.Description;
            product.CategoryId = entity.CategoryId;
            return product;
        }
        private static Product FindProduct(int id)
        {
            var all = DataStorage.Products.Where(p => p.Id == id);
            if (all != null && all.Any())
            {
                var found = all.First();
                return found;
            }
            else
                throw new Exception($"product with id {id} not found..");
        }
    }
}
