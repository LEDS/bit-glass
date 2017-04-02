using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Faturamento
{
    public class TipoAro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoAroId { get; set; }

        public string Descricao { get; set; }
        public List<OrdemServico> OrdensServicos { get; set; }
    }
}