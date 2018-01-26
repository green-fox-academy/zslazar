using Microsoft.EntityFrameworkCore;
using RedditBE.Entities;
using RedditBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBE.Repositories
{
    public class RedditRepository
    {
        private RedditContext redditContext;
                
        public RedditRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public DbSet<Post> GetAllPosts()
        {
            return redditContext.Posts;
        }

        public Post Add(Post json)
        {
            redditContext.Posts.Add(json);
            redditContext.SaveChanges();
            return json;
        }
    }
}
