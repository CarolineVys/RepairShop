using System.Data.Entity;

namespace RepairShop.Models
{
    public class RepairShopContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}