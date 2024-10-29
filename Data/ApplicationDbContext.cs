using Cascading.Core.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Cascading.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories {  get; set; }
        public DbSet<Product> Products {  get; set; }
    }
}
