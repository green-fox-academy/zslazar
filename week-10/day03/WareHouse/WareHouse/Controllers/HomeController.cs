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

        [HttpGet("warehouse")]
        public IActionResult Index()
        {
            return View(clothesService.GenerateVM());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary(string name, string size, int quantity)
        {
            return View(clothesService.GetSummary(name, size, quantity));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Query(double price, string type)
        {
            return Json(new { result = "ok", clothes = clothesService.GetFilteredListByPrice(price, type) });
        }
    }
}
