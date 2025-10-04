using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public String Index()
        {
            return "This is my default action";
        }
        public String Welcome()
        {
            return "This is the Welcome action methode...";
        }
    }
}
