using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Pessoas
{
    public class Cidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CidadeId { get; set; }

        public string Nome { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}