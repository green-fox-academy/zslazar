using Microsoft.EntityFrameworkCore;
using WareHouse.Models;

namespace WareHouse.Entities
{
    public class ClothesContext : DbContext
    {
        public ClothesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Clothes> WarehouseDB { get; set; }
    }
}
