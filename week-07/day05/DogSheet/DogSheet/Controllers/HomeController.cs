using Microsoft.AspNetCore.Mvc;
using DogSheet.Models;
using DogSheet.ViewModels;

namespace DogSheet.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {        
        public static DataViewModel dataVM = new DataViewModel();
        
        [HttpGet("results")]
        public IActionResult Index()
        {
            return View(dataVM);
        }

        [HttpPost("add")]
        public IActionResult AddResults(Data data)
        {
            dataVM.Participants.Add(data);
            return RedirectToAction("Index");
        }
    }
}
