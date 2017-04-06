using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using bitGlass.Models.Faturamento;
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

        public List<OrdemServico> OrdensPendentes()
        {
            return _context.OrdensServicos
                .Where(o => o.DataEntregaEfetiva == null)
                .ToList();
        }

        public List<OrdemServico> OrdensPendentesMes()
        {
            return _context.OrdensServicos
                .Where(o => o.DataEntregaEfetiva == null && o.DataEntregaPrevista.Month == DateTime.Now.Month)
                .ToList();
        }

        public PartialViewResult OrdensMesNotificacao()
        {
            return PartialView(OrdensPendentesMes());
        }

        public int QuantidadeOsPendentes()
        {
            return OrdensPendentes().Count;
        }
    }
}