using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Pessoas
{
    public abstract class Telefonavel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TelefonavelId { get; set; }

        public virtual List<Telefone> Telefones { get; set; }
    }
}