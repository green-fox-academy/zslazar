using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cars.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cars.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {

        private CarService carService;

        public RestController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet ("search/{brand}")]
        public IActionResult Index()
        {
            return Json(new { });
        }
    }
}
