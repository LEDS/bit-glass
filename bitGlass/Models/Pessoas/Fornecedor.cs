using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Fornecedor : Telefonavel
    {
        [Required]
        public string NomeFantasia { get; set; }

        public virtual List<OrdemServico> OrdensServicos { get; set; }
    }
}