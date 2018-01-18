using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditFE.Models
{
    public class Post
    {
        public long PostId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }
    }
}
