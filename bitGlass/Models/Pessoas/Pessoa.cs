using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Pessoa : Telefonavel
    {
        public string PrimeiroNome { get; set; }

        public string SegundoNome { get; set; }

        public virtual List<OrdemServico> OrdensServicos { get; set; }
        public virtual List<Receita> Receitas { get; set; }
    }
}