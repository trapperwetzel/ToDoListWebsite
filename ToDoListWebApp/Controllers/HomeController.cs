using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        

        public IActionResult Index()
        {
            return View(UserToDoList.UserList);
        }

        public IActionResult AddTask(string task)
        {
            var taskListItem = new ToDoListItem(task);  
            UserToDoList.UserList.Add(taskListItem);

            return RedirectToAction("Index");
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
