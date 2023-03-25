using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Publicacao
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; private set; }

        public Usuario usuario { get; private set; }

        [Required(ErrorMessage = "O título do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do título não pode exceder 50 caracteres")]
        public string Titulo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatória")]
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "A categoria do filme é obrigatória")]
        public string Tipo { get; set; }

        public ICollection<Interacao>? Interacoes { get; private set; }

        public Publicacao()
        {

        }

        public Publicacao(int usuarioId, Usuario usuario, string titulo, string descricao, string genero, int duracao, string tipo)
        {
            UsuarioId = usuarioId;
            this.usuario = usuario;
            Titulo = titulo;
            Descricao = descricao;
            Genero = genero;
            Duracao = duracao;
            Tipo = tipo;
        }
    }
}
