using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBE.Repositories;
using RedditBE.Models;

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
            return Json(new { posts = redditRepository.GetAllPosts()});
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Post json)
        {                     
            var addedPost = redditRepository.Add(json);
            return Json(new
            {
                id = addedPost.Id,
                title = addedPost.Title,
                url = addedPost.Url,
                timestamp = addedPost.Timestamp,
                score = addedPost.Score
            });
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
