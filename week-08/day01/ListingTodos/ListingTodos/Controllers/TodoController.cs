using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
               
        [HttpGet("/todo")]
        public IActionResult Index()
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


        [HttpGet("/delete/{id}")]
        public IActionResult Delete(long id)
        {
            repo.DeleteItem(id);
            return RedirectToAction("List");            
        }
    }
}
