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
        [HttpGet]
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
        public async Task<ActionResult> Novo()
        {
            ViewBag.Cidades = new SelectList(await _context.Cidades.ToListAsync(), "CidadeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET /Paciente/Detalhes/1
        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            var paciente = _context.Pacientes
                .Include(p => p.Cidade)
                .FirstOrDefault(p => p.TelefonavelId == id);

            if (paciente != null)
                return View(paciente);

            return HttpNotFound();
        }

        // POST /Paciente/Deletar/1
        public ActionResult Deletar(int id)
        {
            var paciente = _context.Pacientes.First(p => p.TelefonavelId == id);

            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public int QuantidadePacientesInadimplentes()
        {
            // TODO
            return 0;
        }
    }
}