using Microsoft.AspNetCore.Mvc;
using ProjectManager.Models;
using System.Diagnostics;

namespace ProjectManager.Controllers
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
            var tasks = new List<TaskModel>
        {
            new TaskModel { Id = 1, Title = "Первая задача", Comments = new List<CommentModel> {
                new CommentModel { Author = "Иван", Text = "Отличная работа!", Date = DateTime.Now },
                new CommentModel { Author = "Анна", Text = "Не забудь проверить детали.", Date = DateTime.Now }
            }},
            new TaskModel { Id = 2, Title = "Вторая задача" }
        };

            return View(tasks);
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
