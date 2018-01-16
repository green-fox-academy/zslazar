using Microsoft.AspNetCore.Mvc;
using ListingTodos.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
    [Route("")]
    public class TodoController : Controller
    {
        private TodoRepository repo;

        public TodoController(TodoRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return Redirect("/todo");
        }

        [HttpGet("/todo")]
        public IActionResult Todo()
        {
            return View("List", repo.ReturnList());
        }


        [Route("/list")]
        public IActionResult List([FromQuery]bool isActive)
        {
            //var text = "This is my first todo";
            //return Json(text);

            //return View(repo.todoList);
            return View(repo.BoolList(isActive));
        }

        [HttpGet("/todo/add")]
        public IActionResult ViewAddForm()
        {
            return View("Add");
        }

        [HttpPost("/todo/add")]
        public IActionResult CreateListElement(Todo todo)
        {
            repo.CreateNewItem(todo);
            return Redirect("/todo");            
        }

        //Ha id van az URL-ben, akkor azt kell paraméterbe is beadni
        [HttpGet("/{id}/delete")]
        public IActionResult Delete(long id)
        {
            repo.DeleteItem(id);
            return RedirectToAction("List");            
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Edit(long id)
        {
            return View(repo.GetItem(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult Modify(Todo todo, long id)
        {
            repo.EditItem(todo, id);
            return Redirect("/todo");
        }        
    }
}
