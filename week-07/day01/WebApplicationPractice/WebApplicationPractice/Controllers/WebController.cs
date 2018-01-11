using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationPractice.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        //public static int Webcounter { get; set; } = 0;
        private static long Id { get; set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //Hello World Web App
        //[Route("greeting")]
        //public IActionResult Greeting()
        //{
        //    var greeting = new Greeting()
        //    {
        //        Id = 1,
        //        Content = "World"
        //    };

        //    return View(greeting);
        //}

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {           
            
            {
                //Webcounter++;
                var hello = new Greeting(Id, name);
                Id++;
                return View(hello);
            };

        }
    }
}
