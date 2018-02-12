using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using URLShortener.Repositories;
using URLShortener.Models;
using URLShortener.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace URLShortener.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private UrlRepository urlRepository;
        
        public HomeController(UrlRepository urlRepository)
        {
            this.urlRepository = urlRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(urlRepository.GetUrls());
        }

        //CheckHttps, CheckIfLongExsistInDb/SearchLongUrl Randomizer
        [HttpPost("save")]
        public IActionResult AddNewUrl(Url url)
        {
            urlRepository.AddNewUrl(url);
            return Redirect("/");
            //return RedirectToAction("Index");
        }

        [HttpGet("shorten/{shortUrl}")]
        public IActionResult SearchUrl([FromRoute]string shortUrl)
        {
            //urlRepository.SearchShortUrl(shortUrl);
            //return Redirect("/");
            return View("Index", urlRepository.SearchShortUrl(shortUrl));
        }
    }
}
