using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDemo.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int Id { get; set; }

        [Column("product_name")]
        public string Name { get; set; } = "";

        [Column("price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column("product_description")]
        public string Description { get; set; } = "";

        [Column("category_id")]
        [ForeignKey("category_id")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
