using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base(Options)
        {
        }

        private static DbContextOptions Options
        {
            get
            {
                var optionsBuilder = new DbContextOptionsBuilder<NorthwindContext>();
                optionsBuilder.UseSqlServer("Data Source=Eren\\MSSQLSERVER01;Initial Catalog=Project1;Integrated Security=True;TrustServerCertificate=True;");
                return optionsBuilder.Options;
            }
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
