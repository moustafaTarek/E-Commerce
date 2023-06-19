using Microsoft.EntityFrameworkCore;

using Template.DAL.Layer.Entities;

namespace Template.DAL.Layer.Db
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }

		public DbSet<Product> Products  { get; set; }
		public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
