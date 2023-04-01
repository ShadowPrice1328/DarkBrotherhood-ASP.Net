using HelloASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloASP.Controllers
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
        public IActionResult About()
        {
            return View();
        }
		public IActionResult Members()
		{
			return View();
		}
        public IActionResult Gallery()
        {
            return View();
        }
		public IActionResult Donate()
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