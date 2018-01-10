using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("Simba")]
        public IActionResult Simba()
        {
            BankAccount animalOne = new BankAccount("Simba", 2000, "lion");
            return View(animalOne);
        }
    }
}
