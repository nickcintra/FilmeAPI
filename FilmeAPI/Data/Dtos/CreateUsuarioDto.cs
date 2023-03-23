using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos;

public class CreateUsuarioDto
{

    [Required(ErrorMessage = "O Email é obrigatório")]
    [StringLength(80)]
    public string Email { get; set; }

    [Required(ErrorMessage = "A Senha é obrigatória")]
    [MaxLength(8, ErrorMessage = "O tamanho da senha não pode exceder 8 caracteres")]
    public string Senha { get; set; }
}
