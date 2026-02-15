using AI_TV.Models;
using GenerativeAI.Types;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AI_TV.Controllers
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
        [HttpGet]
        public ActionResult Intellia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Intellia(string monInput)
        {
            // model.Message contient le texte du input
            ViewBag.Valeur = monInput;
            return View();
        }
   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
