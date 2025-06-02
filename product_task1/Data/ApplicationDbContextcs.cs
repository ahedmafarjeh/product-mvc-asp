using Microsoft.EntityFrameworkCore;
using product_task1.Models;

namespace product_task1.Data
{
    public class ApplicationDbContextcs:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=T1MVC_11;TrustServerCertificate=True;Trusted_Connection=True");
        }
    }
}
