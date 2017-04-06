using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Faturamento
{
    public class Pagamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PagamentoId { get; set; }

        public DateTime? DataPagamentoEfetiva { get; set; }

        [Required]
        public DateTime DataPagamentoPrevista { get; set; }

        [Required]
        public double ValorPago { get; set; }

        [Required]
        public OrdemServico OrdemServico { get; set; }
    }
}