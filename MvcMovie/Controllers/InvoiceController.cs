using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class InvoiceController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(InvoiceModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.TotalPrice = model.TotalPrice;
            }
            return View(model);
        }
    }
}
