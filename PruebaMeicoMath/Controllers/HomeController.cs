using Microsoft.AspNetCore.Mvc;
using PruebaMeicoMath.Models;
using System.Diagnostics;

namespace PruebaMeicoMath.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Result(int valueOne, int valueTwo)
        {
            var result = valueOne + valueTwo;
            ViewData["ValueOne"] = valueOne;
            ViewData["ValueTwo"] = valueTwo;
            ViewData["Result"] = result;
            return View();
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