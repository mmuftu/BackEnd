using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contextx
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=mustafam;Database=Northwind;User Id=sa;Password=manager;TrustServerCertificate=true");
        }

        DbSet<Product> Products { get; set; }

    }
}
