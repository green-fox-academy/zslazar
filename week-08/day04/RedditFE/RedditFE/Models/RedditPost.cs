﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditFE.Models
{
    public class RedditPost
    {
        [Key]
        public long? PostId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }

        public RedditUser RedditUser { get; set; }
    }
}
