using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Estado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstadoId { get; set; }

        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get; set; }

        public List<HistoricoEstado> HistoricosEstados { get; set; }
    }
}