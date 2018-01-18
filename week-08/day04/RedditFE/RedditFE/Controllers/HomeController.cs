using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditFE.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditFE.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private HomeRepository homeRepository;

        public HomeController(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }


        [HttpGet("index")]
        public IActionResult Index()
        {
            //return View(homeRepository.ReturnList());
            return View();
        }
    }
}
