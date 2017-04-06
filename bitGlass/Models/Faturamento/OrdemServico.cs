using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Pessoas;

namespace bitGlass.Models.Faturamento
{
    public class OrdemServico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdemServicoId { get; set; }

        [Required]
        public DateTime DataSolicitacao { get; set; }

        [Required]
        public DateTime DataEntregaPrevista { get; set; }

        public DateTime? DataEntregaEfetiva { get; set; }

        [Required]
        public int NumeroParcelas { get; set; }

        [Required]
        public double ValorBruto { get; set; }

        [Required]
        public double Desconto { get; set; }

        public string LinhaMontagem { get; set; }
        public string Aro { get; set; }
        public string Observacoes { get; set; }

        [Required]
        public TipoAro TipoAro { get; set; }

        public virtual List<Pagamento> Pagamentos { get; set; }

        [Required]
        public Receita Receita { get; set; }

        [Required]
        public Pessoa DestinatarioPessoa { get; set; }

        [Required]
        public Fornecedor Fornecedor { get; set; }

        public virtual List<HistoricoEstado> HistoricosEstados { get; set; }
    }
}