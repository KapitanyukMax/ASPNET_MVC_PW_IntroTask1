using ASPNET_MVC_PW_IntroTask1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNET_MVC_PW_IntroTask1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Model()
        {
            return View();
        }

        public IActionResult View()
        {
            return base.View();
        }

        public IActionResult Controller()
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