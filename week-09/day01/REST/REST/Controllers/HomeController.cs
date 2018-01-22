using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace REST.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        //Create a HomeController with a single endpoint to /
        //The method should return File("index.html", "text/html") here

        
        [HttpGet("")]
        public IActionResult GetFile()
        {
            return File("index.html", "text/html");
        }

        /* Create a GET /doubling endpoint
        That receives a query parameter: input=15
        And responds with a json object with the doubled amount of the input:
        {
          "received": 15,
          "result": 30
        }
        if no input is provided:
        {
          "error": "Please provide an input!"
        }*/
                
    }
}
