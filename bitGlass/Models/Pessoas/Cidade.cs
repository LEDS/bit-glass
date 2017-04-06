using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Pessoas
{
    public class Cidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CidadeId { get; set; }

        [Required]
        public string Nome { get; set; }

        public virtual List<Paciente> Pacientes { get; set; }
    }
}