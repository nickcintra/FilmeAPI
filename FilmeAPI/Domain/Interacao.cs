using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Interacao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario usuario { get; set; }
        public TipoInteracao tipoInteracao { get; set; }
        public int PublicacaoId { get; set; }
        public Publicacao publicacao { get; set; }


        public Interacao() { }

        public Interacao(int usuarioid, TipoInteracao tipoInteracao, Usuario usuario, Publicacao publicacao, int publicacaoId)
        {
            UsuarioId = usuarioid;
            this.tipoInteracao = tipoInteracao;
            this.usuario = usuario;
            this.publicacao = publicacao;
            PublicacaoId = publicacaoId;
        }
    }
}
