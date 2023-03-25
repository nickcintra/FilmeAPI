using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        public string email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória")]
        [MaxLength(8, ErrorMessage = "O tamanho da senha não pode exceder 8 caracteres")]
        public string senha { get; set; }

        public List<Publicacao>? publicacoes { get; set; }
        public List<Interacao>? interacoes { get; set; }

        public Usuario()
        {
            
        }

        public Usuario(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }
    }
}

