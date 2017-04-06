using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Pessoas
{
    public class Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TelefoneId { get; set; }

        [Required]
        public int Ddd { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public Telefonavel Telefonavel { get; set; }
    }
}