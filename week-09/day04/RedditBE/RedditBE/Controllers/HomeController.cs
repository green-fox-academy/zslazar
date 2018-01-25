using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditBE.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("posts")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("posts")]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("posts/{id}/upvote")]
        public IActionResult Upvote()
        {
            return Ok();
        }

        [HttpPut("posts/{id}/downvote")]
        public IActionResult Downvote()
        {
            return Ok();
        }                
    }
}
