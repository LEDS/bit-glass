using System.Linq;
using System.Web.Mvc;
using bitGlass.Models.Pessoas;
using bitGlass.Patterns.DataAccessLayer;

namespace bitGlass.Controllers
{
    public class LoginController : Controller
    {
        private readonly AdminContext _context = new AdminContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(UsuarioLogin usuarioLogin)
        {
            if (_context.Logins.Any(u => u.Username == usuarioLogin.Username && u.Password == usuarioLogin.Password))
            {
                TempData["User"] = usuarioLogin;
                return RedirectToAction("Index", "Home");
            }

            return new HttpNotFoundResult();
        }
    }
}