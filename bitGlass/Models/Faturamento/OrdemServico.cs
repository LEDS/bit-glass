using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Pessoas;

namespace bitGlass.Models.Faturamento
{
    public class OrdemServico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdemServicoId { get; set; }

        public int ReceitaId { get; set; }
        public int PessoaId { get; set; }
        public int TipoAroId { get; set; }
        public int FornecedorId { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataEntregaPrevista { get; set; }
        public DateTime DataEntregaEfetica { get; set; }
        public int NumeroParcelas { get; set; }
        public double ValorBruto { get; set; }
        public double Desconto { get; set; }
        public string LinhaMontagem { get; set; }
        public string Aro { get; set; }
        public string Observacoes { get; set; }

        public TipoAro TipoAro { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public Receita Receita { get; set; }
        public Pessoa DestinatarioPessoa { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<HistoricoEstado> HistoricosEstados { get; set; }
    }
}