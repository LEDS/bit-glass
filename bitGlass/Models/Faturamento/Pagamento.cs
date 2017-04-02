using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Faturamento
{
    public class Pagamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PagamentoId { get; set; }

        public int OrdemServicoId { get; set; }
        public DateTime DataPagamentoEfetiva { get; set; }
        public DateTime DataPagamentoPrevista { get; set; }
        public double ValorPago { get; set; }
        public OrdemServico OrdemServico { get; set; }
    }
}