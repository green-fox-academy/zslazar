using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URLShortener.Models
{
    public class Url
    {
        public long? Id { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
    }
}
