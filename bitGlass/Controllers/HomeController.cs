using System.Web.Mvc;

namespace bitGlass.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}