using FilmeAPI.Models;

namespace FilmeAPI.Requests;

public record PublicacaoRequest(int UsuarioId, string Titulo, string Descricao, string Genero, int Duracao, string Tipo);
