using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST.Models;

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

        //http://localhost:52838/greeter?name=Zsuska&title=student
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

        //solution 2
        // {            
        //    if (name != null && title != null)
        //    {
        //        return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        //    }
        //    if (name == null)
        //    {
        //        return Json(new { error = "Please provide a name!" });
        //    }
        //    return Json(new { error = "Please provide a title!" });
        //}


        /* Create a dynamic GET /appenda/{appendable} endpoint that responds with the appended a: 
         * eg. /appenda/kuty responds with:
        {
        "appended": "kutya"
        }
        if no appendable is provided, thats a different endpoint so the server should respond with 404 */

        //http://localhost:52838/appenda/kuty
        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }
            return Json(new { appended = appendable + "a" });
            
            //return Json(new { appended = $"{word} + a" });
        }

        /* Create a dynamic POST /dountil/{what} endpoint That receives a number in a json object:
        {
          "until": 15
        }
        and responds with sum or multiplication of all elements until that number:
        eg. /dountil/sum with {"until": 5} will respond {"result": 15}
        eg. /dountil/factor with {"until": 5} will respond {"result": 120}
        if no number is provided:
        {
          "error": "Please provide a number!"
        }*/

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromBody] Item item, [FromRoute] string what)
        //lehetett volna ez is
        //public IActionResult DoUntil([FromRoute]string what, int? item)
        {
            if (item != null)
            {
                if (what.Equals("sum"))
                //if (what == "sum")
                {
                    int result = 0;
                    for (int i = 1; i < item.Until + 1; i++)
                    {
                        result += i;
                    }
                    return Json(new { result = result });
                }
                if (what.Equals("factor"))
                //if (what == "factor")
                {
                    int result = 1;
                    for (int i = 1; i < item.Until + 1; i++)
                    {
                        result *= i;
                    }
                    return Json(new { result = result });
                }
            }
            return Json(new { error = "Please provide a number!" });
            //return NotFound();

        }

        [HttpPost("arrays")]
        public IActionResult ArrayHandler()
        {

        }
    }
}
