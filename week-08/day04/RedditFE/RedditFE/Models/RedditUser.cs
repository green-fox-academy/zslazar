using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditFE.Models
{
    public class RedditUser
    {
        [Key]
        public long? UserId { get; set; }
        public string UserName { get; set; }

        public ICollection<RedditPost> RedditPost { get; set; }
    }
}
