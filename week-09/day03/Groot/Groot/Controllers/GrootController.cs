using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    [Route("")]
    public class GrootController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //http://localhost:53991/groot?message=Zsuska
        [HttpGet("groot")]
        public IActionResult Groot([FromQuery] string message)
        {
            if (message == null)
            {
                //return Json(new { error = "I am Groot!" });
                return BadRequest(new { error = "I am Groot!" });
            }
            return Json(new { received = message, translated = "I am Groot!" });
        }


    }
}
