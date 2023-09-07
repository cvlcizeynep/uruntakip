using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using StockTakip.WebAPP.Models;

namespace StockTakip.WebAPP.Repository
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions opt):base(opt) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Stok_Takip_Db; Trusted_Connection=true");
        }
         public DbSet<Models.Product> Products { get; set; }
        public DbSet< Category>Categories { get; set; }


    }
}

