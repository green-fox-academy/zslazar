using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URLShortener.Models;

namespace URLShortener.Entities
{
    public class UrlContext : DbContext
    {
        public UrlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Url> Urls { get; set; }
    }
}
