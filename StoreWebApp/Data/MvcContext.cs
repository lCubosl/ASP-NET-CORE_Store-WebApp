using Microsoft.EntityFrameworkCore;
using StoreWebApp.Models;

namespace StoreWebApp.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options) {}
        public DbSet<Item> Items { get; set; }

    }
}
