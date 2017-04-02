using System.Collections.Generic;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Pessoa : Telefonavel
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public List<OrdemServico> OrdensServicos { get; set; }
        public List<Receita> Receitas { get; set; }
    }
}