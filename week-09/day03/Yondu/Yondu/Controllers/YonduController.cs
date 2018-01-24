using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yondu.Controllers
{
    [Route("")]
    public class YonduController : Controller
    {

        //http://localhost:54916/yondu?distance=10&time=10
        [HttpGet("yondu")]
        public IActionResult Yondu([FromQuery]double? distance, [FromQuery] double? time)
        {
            if (distance is null || time is null || time == 0)
            {
                return BadRequest(new { error = "Error occured!" });
            }
            return Json(new { distance = distance, time = time, speed = distance / time });
        }
    }
}
