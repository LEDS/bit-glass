using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Pessoas;

namespace bitGlass.Models.Faturamento
{
    public class HistoricoEstado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HistoricoEstadoId { get; set; }

        [Required]
        public Estado Estado { get; set; }

        [Required]
        public DateTime DataEntrada { get; set; }

        [Required]
        public OrdemServico OrdemServico { get; set; }
    }
}