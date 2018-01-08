using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPractice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationPractice.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int Counter { get; set; } = 0;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //Hello World REST App
        //[Route("greeting")]
        //public IActionResult Greeting()
        //{
        //    var hello = new Greeting();
        //    return new JsonResult(hello);
        //}
        //[Route("greeting/{id}")]

        //[Route("greeting")]
        //public IActionResult Greeting(int Counter, string name)
        //public IActionResult Greeting()
        //{
            //Counter++;
            //var hello = new Greeting(Counter, name);
            //var hello = new Greeting();
            //return new JsonResult(hello);
        //}
    }
}
