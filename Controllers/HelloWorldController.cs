using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //
        //GET: /HelloWorld/Welcome
        public IActionResult Welcome(String name = "Ayman", int numTimes = 1, int ID = 1)
        {
            ViewData["name"] = "Hello " + name;
            ViewData["message"] = "This is my message to you";
            ViewData["numTimes"] = numTimes;
            ViewData["ID"] = ID;
            return View();
        }
    }
}
