using RedditFE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditFE.Repositories
{
    public class HomeRepository
    {
        private HomeContext homeContext;

        public HomeRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

    }
}
