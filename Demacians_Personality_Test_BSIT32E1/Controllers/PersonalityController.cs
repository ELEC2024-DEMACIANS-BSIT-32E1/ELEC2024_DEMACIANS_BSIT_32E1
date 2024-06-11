using Demacians_Personality_Test_BSIT32E1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demacians_Personality_Test_BSIT32E1.Controllers
{
    public class PersonalityController : Controller
    {
        private readonly ILogger<PersonalityController> _logger;

        public PersonalityController(ILogger<PersonalityController> logger)
        {
            _logger = logger;
        }

        public IActionResult PersonalityPage()
        {
            return View();
        }

        public IActionResult Logician()
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
