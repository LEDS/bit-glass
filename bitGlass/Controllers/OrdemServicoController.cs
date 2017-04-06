using System;
using System.Linq;
using System.Web.Mvc;
using bitGlass.Patterns.DataAccessLayer;

namespace bitGlass.Controllers
{
    public class OrdemServicoController : Controller
    {
        private readonly AppContext _context = new AppContext();

        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public ActionResult VerificarStatus()
        {
            throw new NotImplementedException();
        }

        public int ObterOrdensPendentes()
        {
            return _context.OrdensServicos.Count(o => o.DataEntregaEfetiva == null);
        }
    }
}