using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using bitGlass.Models.Faturamento;

namespace bitGlass.Models.Pessoas
{
    public class Receita
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReceitaId { get; set; }

        public int PacienteId { get; set; }
        public int PessoaId { get; set; }

        public DateTime DataEmissao { get; set; }

        // Dnp
        public double DireitoDnpLonge { get; set; }
        public double DireitoDnpPerto { get; set; }
        public double EsquerdoDnpLonge { get; set; }
        public double EsquerdoDnpPerto { get; set; }

        // Esferico
        public double DireitoEsfericoPerto { get; set; }
        public double DireitoEsfericoLonge { get; set; }
        public double EsquerdoEsfericoPerto { get; set; }
        public double EsquerdoEsfericoLonge { get; set; }

        // Cilindrico
        public double DireitoCilindricoPerto { get; set; }
        public double DireitoCilindricoLonge { get; set; }
        public double EsquerdoCilindricoPerto { get; set; }
        public double EsquerdoCilindricoLonge { get; set; }

        // Eixo
        public double DireitoEixoPerto { get; set; }
        public double DireitoEixoLonge { get; set; }
        public double EsquerdoEixoPerto { get; set; }
        public double EsquerdoEixoLonge { get; set; }

        // Altura
        public double DireitoAlturaPerto { get; set; }
        public double DireitoAlturaLonge { get; set; }
        public double EsquerdoAlturaPerto { get; set; }
        public double EsquerdoAlturaLonge { get; set; }

        // Adicao
        public double DireitoAdicao { get; set; }
        public double EsquerdoAdicao { get; set; }

        // Observacoes
        public string Observacoes { get; set; }

        public Pessoa Medico { get; set; }
        public Paciente Paciente { get; set; }
        public List<OrdemServico> OrdensServicos { get; set; }
    }
}