using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPractice.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(int Counter, string name)
        {
            Id = Counter;
            Content = "Hello, " + name;

        }
    }
}
