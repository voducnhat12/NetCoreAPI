using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ScoreController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ScoreModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FinalScore = model.FinalScore;
                ViewBag.Grade = model.Grade;
            }
            return View(model);
        }
    }
}
