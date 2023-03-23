using FilmeAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmeAPI.Models
{
    public class Publicacao
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int IdUsuario { get; set; }

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
        public CategoriaFilme _categoriaFilme { get; set; }

        public ICollection<Interacao> Interacoes { get; set; }

        public Publicacao()
        {
            
        }

        public Publicacao(int idUsuario, string titulo, string descricao, string genero, int duracao, CategoriaFilme categoriaFilme, ICollection<Interacao> interacoes)
        {
            IdUsuario = idUsuario;
            Titulo = titulo;
            Descricao = descricao;
            Genero = genero;
            Duracao = duracao;
            _categoriaFilme = categoriaFilme;
            Interacoes = interacoes;
        }
    }
}
