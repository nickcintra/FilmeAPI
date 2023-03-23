using FilmeAPI.Enums;
using FilmeAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos
{
    public class CreatePublicacaoDto
    {

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do título não pode exceder 50 caracteres")]
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
    }
}
