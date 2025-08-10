using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    // Model class (make sure you have this defined separately)
  

    // DbContext class
    public class ProductContext : DbContext
    {
        public DbSet<product> Products { get; set; }

        public DbSet<category> Categories { get; set; }
       // Constructor - notice the correct spelling: DbContextOptions(not DbContextoption)
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        // Optional: Configure connection string here if not using DI
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-LNSND5B;Database=ProductDb;Integrated Security=True;TrustServerCertificate=True;");


        }
    }
}
