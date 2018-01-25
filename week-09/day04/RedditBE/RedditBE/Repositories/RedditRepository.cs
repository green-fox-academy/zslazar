using RedditBE.Entities;
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

    }
}
