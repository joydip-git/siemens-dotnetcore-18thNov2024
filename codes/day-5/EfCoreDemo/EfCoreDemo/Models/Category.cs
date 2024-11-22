using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDemo.Models
{
    [Table(name: "categories")]
    public class Category
    {
        [Key]
        [Column("category_id")]
        public int Id { get; set; }

        [Column("category_name", TypeName = "varchar(20")]
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
