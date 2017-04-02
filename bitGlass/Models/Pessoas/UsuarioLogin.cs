using System.ComponentModel.DataAnnotations;

namespace bitGlass.Models.Pessoas
{
    public class UsuarioLogin
    {
        public int UsuarioLoginId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}