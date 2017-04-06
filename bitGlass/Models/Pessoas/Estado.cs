using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Estado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstadoId { get; set; }

        [Required]
        public string DescricaoCurta { get; set; }

        [Required]
        public string DescricaoLonga { get; set; }

        public virtual List<HistoricoEstado> HistoricosEstados { get; set; }
    }
}