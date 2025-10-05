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
        public String Welcome(String name = "Ayman", int numTimes = 1, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name},Your ID is: {ID} NumTimes is: {numTimes}");
        }
    }
}
