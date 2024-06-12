using Demacians_Personality_Test_BSIT32E1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demacians_Personality_Test_BSIT32E1.Controllers
{
    public class LandingPageController : Controller
    {
        private readonly ILogger<LandingPageController> _logger;

        public LandingPageController(ILogger<LandingPageController> logger)
        {
            _logger = logger;
        }

        public IActionResult LandingPage()
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
