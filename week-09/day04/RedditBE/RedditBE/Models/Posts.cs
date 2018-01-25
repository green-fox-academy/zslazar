using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBE.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Url { get; set; }
        public int Timestamp { get; set; }
        public int Score { get; set; }
    }
}
