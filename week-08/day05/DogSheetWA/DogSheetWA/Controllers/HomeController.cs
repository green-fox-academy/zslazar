using DogSheetWA.Models;
using DogSheetWA.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogSheetWA.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private DogRepository dogRepository;

        public HomeController(DogRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }

        //[HttpGet("/index")]
        //public IActionResult Index()
        //{
        //    return View(dogRepository.ReturnList());
        //}

        //[HttpGet("/")]
        //public IActionResult Index()
        //{
        //    return Redirect("/results");
        //}

        [HttpGet("/results")]
        public IActionResult Result()
        {
            return View("Index", dogRepository.ReturnList());
        }

        [HttpGet("/add")]
        public IActionResult ViewAddForm()
        {
            return View("Add");
        }

        [HttpPost("/add")]
        public IActionResult CreateNewElement(Sheet sheet)
        {
            dogRepository.CreateNewItem(sheet);
            return Redirect("/results");
        }

        //Ha id van az URL-ben, akkor azt kell paraméterbe is beadni
        [HttpGet("/{id}/delete")]
        public IActionResult Delete(long id)
        {
            dogRepository.DeleteItem(id);
            return Redirect("/results");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Edit(long id)
        {
            return View(dogRepository.GetItem(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult Modify(Sheet data, long id)
        {
            dogRepository.EditItem(data, id);
            return Redirect("/results");
        }
    }
}
