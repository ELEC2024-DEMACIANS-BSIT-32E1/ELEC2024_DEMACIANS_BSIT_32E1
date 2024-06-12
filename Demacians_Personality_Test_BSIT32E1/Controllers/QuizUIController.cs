using Demacians_Personality_Test_BSIT32E1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demacians_Personality_Test_BSIT32E1.Controllers
{
    public class QuizUIController : Controller
    {
        private readonly ILogger<QuizUIController> _logger;

        public QuizUIController(ILogger<QuizUIController> logger)
        {
            _logger = logger;
        }

        public IActionResult QuizPage1()
        {
            return View();
        }

        public IActionResult QuizPage2()
        {
            return View();
        }
        public IActionResult QuizPage3()
        {
            return View();
        }
        public IActionResult QuizPage4()
        {
            return View();
        }
        public IActionResult QuizPage5()
        {
            return View();
        }
        public IActionResult QuizPage6()
        {
            return View();
        }
        public IActionResult QuizPage7()
        {
            return View();
        }
        public IActionResult QuizPage8()
        {
            return View();
        }
        public IActionResult QuizPage9()
        {
            return View();
        }
        public IActionResult QuizPage10()
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
