using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//Create a HomeController with a single endpoint to /
//The method should return File("index.html", "text/html") here


namespace REST.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult GetFile()
        {
            return File("index.html", "text/html");
        }
                
    }
}
