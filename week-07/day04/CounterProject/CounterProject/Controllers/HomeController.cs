using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CounterProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CounterProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost("add")]
        public IActionResult Counter()
        {
            counter.ClickCounter++;
            return RedirectToAction("Index");
        }
    }
}
