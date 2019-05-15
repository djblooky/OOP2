using BasicMVCSite2;
using System.Diagnostics;
using System.Web.Mvc;

namespace BasicMVCSite2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This page says yee haw";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "haleyphillips.com";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
