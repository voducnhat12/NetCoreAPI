using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
       public IActionResult Index()
   {
        return View(); // Đúng, View() trả về ViewResult, phù hợp với IActionResult
   }
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
