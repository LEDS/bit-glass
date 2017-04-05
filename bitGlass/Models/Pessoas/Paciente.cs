using System;
using System.Collections.Generic;

namespace bitGlass.Models.Pessoas
{
    public class Paciente : Pessoa
    {
        public DateTime DataNascimento { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public int Cpf { get; set; }
        public string Rg { get; set; }
        public Cidade Cidade { get; set; }
        public new List<Receita> Receitas { get; set; }
    }
}