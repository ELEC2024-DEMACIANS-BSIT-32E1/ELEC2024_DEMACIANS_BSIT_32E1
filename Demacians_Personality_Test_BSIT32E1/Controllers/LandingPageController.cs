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

        public IActionResult DownloadFileProtagonist()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/landingpage.png");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/pdf", "landingpage.png");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
