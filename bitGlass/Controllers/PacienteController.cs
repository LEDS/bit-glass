using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI;
using bitGlass.Patterns.DataAccessLayer;

namespace bitGlass.Controllers
{
    public class PacienteController : Controller
    {
        private readonly AppContext _context = new AppContext();

        public async Task<ActionResult> Index()
        {
            return View(await _context.Pacientes.Include(p => p.Cidade).ToListAsync());
        }

        public ActionResult Novo()
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Detalhes(int id)
        {
            return View();
        }

        public ActionResult Deletar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}