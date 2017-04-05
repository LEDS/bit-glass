using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using bitGlass.Models.Pessoas;
using bitGlass.Patterns.DataAccessLayer;

namespace bitGlass.Controllers
{
    public class PacienteController : Controller
    {
        private readonly AppContext _context = new AppContext();

        // GET /Paciente/Index
        public async Task<ActionResult> Index()
        {
            var pacientes = await _context.Pacientes
                .Include(p => p.Cidade)
                .OrderBy(p => p.PrimeiroNome)
                .ToListAsync();

            return View(pacientes);
        }

        // GET /Paciente/Novo
        [HttpGet]
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        // GET /Paciente/Detalhes/1
        public ActionResult Detalhes(int id)
        {
            return View();
        }

        // POST /Paciente/Deletar/1
        public ActionResult Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}