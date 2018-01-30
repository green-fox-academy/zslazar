using Cars.Models;
using Cars.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        private CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]FilterOption filterOption)
        {
            return View(carService.GetFilteredList(filterOption));
        }

        [HttpGet("search/{brand}")]
        public IActionResult SearchBrand(string brand)
        {
            return View("Search", carService.GetCarsByBrand(brand));
        }
    }
}
