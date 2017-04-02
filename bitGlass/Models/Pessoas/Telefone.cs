using System.ComponentModel.DataAnnotations.Schema;

namespace bitGlass.Models.Pessoas
{
    public class Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TelefoneId { get; set; }

        public int TelefonavelId { get; set; }
        public int Ddd { get; set; }
        public int Numero { get; set; }
        public Telefonavel Telefonavel { get; set; }
    }
}