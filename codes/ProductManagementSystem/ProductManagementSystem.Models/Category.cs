namespace ProductManagementSystem.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Product>? Products { get; set; }
        public Category()
        {

        }
        public Category(int id, string name, List<Product>? products)
        {
            Id = id;
            Name = name;
            Products = products;
        }
    }
}
