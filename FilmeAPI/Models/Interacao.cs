using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmeAPI.Models
{
    public class Interacao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Usuario IdUsuario { get; set; }
        public int IdPublicacao { get; set; }
        public bool Segue { get; set; }
        public bool Recomenda { get; set; }
        public bool NaoRecomenda { get; set; }

        public Interacao() { }

        public Interacao(int id, Usuario usuario, int idPublicacao, bool segue, bool recomenda, bool naoRecomenda)
        {
            Id = id;
            IdUsuario = usuario;
            IdPublicacao = idPublicacao;
            Segue = segue;
            Recomenda = recomenda;
            NaoRecomenda = naoRecomenda;
        }
    }
}
