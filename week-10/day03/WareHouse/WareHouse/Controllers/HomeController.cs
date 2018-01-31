using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WareHouse.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WareHouse.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ClothesService clothesService;

        public HomeController(ClothesService clothesService)
        {
            this.clothesService = clothesService;
        }

        [HttpGet("shoppingplanner")]
        public IActionResult Index()
        {
            return View(clothesService.GetClothes());
        }

        [HttpGet("shoppingplanner/summary")]
        public IActionResult Summary()
        {
            return View();
        }
    }
}
