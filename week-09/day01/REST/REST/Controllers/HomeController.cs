using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        //Create a HomeController with a single endpoint to /
        //The method should return File("index.html", "text/html") here
                
        [HttpGet("/")]
        public IActionResult GetFile()
        {
            return File("index.html", "text/html");
        }

        /* Create a GET /doubling endpoint That receives a query parameter: input=15
        And responds with a json object with the doubled amount of the input:
        {
          "received": 15,
          "result": 30
        }
        if no input is provided:
        {
          "error": "Please provide an input!"
        }*/

        // /api/home/doubling?input=6
        //http://localhost:52838/doubling?input=72
        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });                       
        }

        /* Create a GET /greeter endpoint that receives a query parameter name = Petike & title = student
        and responds with an awesome greeting json object:
        {
          "welcome_message": "Oh, hi there Petike, my dear student!"
        }
        if e.g.no name(or title) is provided:
        {
          "error": "Please provide a name!"
        }  */

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery] string name, [FromQuery] string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
    }
}
