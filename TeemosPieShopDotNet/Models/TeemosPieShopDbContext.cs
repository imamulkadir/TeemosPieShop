using Microsoft.EntityFrameworkCore;

namespace TeemosPieShopDotNet.Models
{
    public class TeemosPieShopDbContext : DbContext
    {
        public TeemosPieShopDbContext(DbContextOptions<TeemosPieShopDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
    }
}
