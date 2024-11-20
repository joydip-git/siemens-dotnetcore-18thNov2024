using ProductManagementSystem.Models;

namespace ProductManagementSystem.Storage
{
    public static class DataStorage
    {
        public static HashSet<Category> Categories { get; private set; }
        public static HashSet<Product> Products { get; private set; }

        static DataStorage()
        {
            Categories = [new Category { Id = 1, Name = "Laptop" }];
            Products = [
                new Product { Id = 1, Name = "Dell XPS 15", Price = 120000, Description = "New laptop from dell", CategoryId = 1 }
                ];
        }
    }
}
