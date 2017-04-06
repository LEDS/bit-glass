using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Faturamento
{
    public class TipoAro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoAroId { get; set; }

        [Required]
        public string Descricao { get; set; }

        public virtual List<OrdemServico> OrdensServicos { get; set; }
    }
}