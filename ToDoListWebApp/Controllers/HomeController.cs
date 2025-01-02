using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoListWebApp.Models;

namespace ToDoListWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

     
        private readonly ToDoListContext _context;

        public HomeController(ILogger<HomeController> logger, ToDoListContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var userList = _context.ToDoListItems.ToList();
            return View(userList);
        }

        public IActionResult AddTask(string task)
        {

            if (!string.IsNullOrWhiteSpace(task))
            {
                var newTask = new ToDoListItem { Task = task, IsCompleted = false };
                _context.ToDoListItems.Add(newTask);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
            
        }

        public IActionResult MarkAsCompleted(int id)
        {
            var task = _context.ToDoListItems.FirstOrDefault(t => t.ID == id);
            if (task != null)
            {
                task.IsCompleted = true;
                _context.SaveChanges(); // Commit the changes
            }
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
