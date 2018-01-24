using DogSheetWA.Models;
using DogSheetWA.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DogSheetWA.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        private DogRepository dogRepository;

        public LoginController(DogRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }

        [HttpGet("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            if(name == "Lili")
            {
            return Redirect("/results");
            }
            return View();
           //return BadRequest();
        }
    }
}
