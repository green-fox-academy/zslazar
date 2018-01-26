using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBE.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditBE.Controllers
{
    [Route("posts")]
    public class HomeController : Controller
    {
        private RedditRepository redditRepository;

        public HomeController(RedditRepository redditRepository)
        {
            this.redditRepository = redditRepository;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("")]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("{id}/upvote")]
        public IActionResult Upvote()
        {
            return Ok();
        }

        [HttpPut("{id}/downvote")]
        public IActionResult Downvote()
        {
            return Ok();
        }                
    }
}
