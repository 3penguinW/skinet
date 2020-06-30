
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext/*query db*/
    {
        public StoreContext( DbContextOptions <StoreContext> options) : base (options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}