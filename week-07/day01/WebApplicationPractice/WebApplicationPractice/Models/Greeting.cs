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

        //public Greeting(int Counter, string name)
        //{
        //    Id = Counter;
        //    Content = "Hello, " + name;

        //}

        //Hello World Web App
        //public Greeting()
        //{          
        //}

        //public Greeting(int Counter, string name)
        //{
        //    Id = Counter;
        //    Content = "Hello, " + name;
        //}

        public Greeting(long id, string name)
        {
            Content = name;
            Id = id;
        }

    }
}
