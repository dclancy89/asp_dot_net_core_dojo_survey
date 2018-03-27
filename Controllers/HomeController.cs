using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Dojo_Survey
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("success")]
        public IActionResult Success(string your_name, string dojo_location, string favorite_language, string comment)
        {
            ViewBag.your_name = your_name;
            ViewBag.dojo_location = dojo_location;
            ViewBag.favorite_language = favorite_language;
            ViewBag.comment = comment;
            return View();
        }
    }
}