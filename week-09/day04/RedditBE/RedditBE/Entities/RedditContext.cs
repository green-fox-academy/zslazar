using Microsoft.EntityFrameworkCore;
using RedditBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBE.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }

        public DbSet<Post> SheetData { get; set; }

    }
}
