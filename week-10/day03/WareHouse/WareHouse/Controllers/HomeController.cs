using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WareHouse.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("shoppingplanner")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("shoppingplanner/summary")]
        public IActionResult Summary()
        {
            return View();
        }
    }
}
