using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using URLShortener.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace URLShortener.Controllers
{
    [Route("shortends")]
    public class RESTController : Controller
    {
        private UrlRepository urlRepository;

        public RESTController(UrlRepository urlRepository)
        {
            this.urlRepository = urlRepository;
        }

        [HttpGet("")]
        public IActionResult ReturnJson()
        {
            return Json(new { urls = urlRepository.GetUrls() });
        }
    }
}
