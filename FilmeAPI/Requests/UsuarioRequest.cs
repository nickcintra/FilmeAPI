using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Requests;

public record UsuarioRequest(string Email, string Senha);

