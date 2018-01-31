using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
