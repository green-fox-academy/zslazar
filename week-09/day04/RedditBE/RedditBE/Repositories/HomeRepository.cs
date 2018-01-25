using RedditBE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBE.Repositories
{
    public class HomeRepository
    {
        private RedditContext homeContext;
                
        public HomeRepository(RedditContext homeContext)
        {
            this.homeContext = homeContext;
        }

    }
}
