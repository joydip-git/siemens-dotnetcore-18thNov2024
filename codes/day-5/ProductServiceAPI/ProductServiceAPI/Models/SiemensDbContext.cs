using Microsoft.EntityFrameworkCore;

namespace ProductServiceAPI.Models
{
    public class SiemensDbContext : DbContext
    {
        public SiemensDbContext(DbContextOptions<SiemensDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server=.\sqlexpress;database=siemensdatabase;user id=sa;password=sqlserver2024;TrustServerCertificate=True");
        //}
    }
}
