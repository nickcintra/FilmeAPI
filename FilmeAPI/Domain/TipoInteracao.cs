using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class TipoInteracao
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string tipoInteracao { get; set; }
    }
}

