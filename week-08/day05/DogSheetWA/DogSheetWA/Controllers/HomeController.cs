using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DogSheetWA.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogSheetWA.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private DogRepository dogRepository;

        public HomeController(DogRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            return View(dogRepository.ReturnList());
        }
    }
}
