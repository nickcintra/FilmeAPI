using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória")]
        [MaxLength(8, ErrorMessage = "O tamanho da senha não pode exceder 8 caracteres")]
        public string Senha { get; set; }

    }
}

