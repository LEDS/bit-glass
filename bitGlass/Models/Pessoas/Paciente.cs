using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bitGlass.Models.Pessoas
{
    public class Paciente : Pessoa
    {
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public int CidadeId { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public int Cep { get; set; }

        [Required]
        public int Cpf { get; set; }

        [Required]
        public string Rg { get; set; }

        public Cidade Cidade { get; set; }

        public new virtual List<Receita> Receitas { get; set; }
    }
}