using Microsoft.EntityFrameworkCore;
using RedditFE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditFE.Entities
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions<HomeContext> options) : base(options)
        {
        }

        public DbSet<RedditPost> RedditPosts { get; set; }
        public DbSet<RedditUser> RedditUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RedditUser>()
                 .HasMany(x => x.RedditPost)
                 .WithOne(x => x.RedditUser);
        }

        //         .HasPrincipalKey(x => x.UserId);
        //         .HasForeignKey(x => x.PostId);
    }
}
