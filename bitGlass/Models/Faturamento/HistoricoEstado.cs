using System;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Pessoas;

namespace bitGlass.Models.Faturamento
{
    public class HistoricoEstado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HistoricoEstadoId { get; set; }

        public int EstadoId { get; set; }
        public int OrdemServicoId { get; set; }
        public Estado Estado { get; set; }
        public DateTime DataEntrada { get; set; }
        public OrdemServico OrdemServico { get; set; }
    }
}