using System.Collections.Generic;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Fornecedor : Telefonavel
    {
        public string NomeFantasia { get; set; }
        public List<OrdemServico> OrdensServicos { get; set; }
    }
}