using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Repositories;
using FilmeAPI.Requests;
using Microsoft.EntityFrameworkCore;

namespace FilmeAPI.Services;

public class PublicacaoService
{
    private readonly PublicacaoRepository publicacaoRepository;
    private readonly InteracoesRepository interacoesRepository;
    private readonly UsuarioRepository usuarioRepository;

    public PublicacaoService(FilmeDbContext filmeDbContext)
    {
        publicacaoRepository = new PublicacaoRepository(filmeDbContext);
        interacoesRepository = new InteracoesRepository(filmeDbContext);
        usuarioRepository = new UsuarioRepository(filmeDbContext);
    }

    public IQueryable GetPublicacoes()
    {
        return publicacaoRepository.GetPublicacoes();
    }

    public IQueryable GetPublicacoesPorUsuario(int idUsuario)
    {
        return publicacaoRepository.GetPublicacoes()
                .Join(
                    interacoesRepository.GetInteracoes(),
                    publicacao => publicacao.Id,
                    interacao => interacao.Id,
                    (publicacao, interacao) =>
                    new
                    {
                        idPublicacao = publicacao.Id,
                        idUsuario = publicacao.UsuarioId,

                    }).Where(w => w.idUsuario == idUsuario);
    }

    public bool criarPublicacao(PublicacaoRequest publicacao)
    {
        Usuario usuario = usuarioRepository.GetUsuarioUnico(publicacao.UsuarioId);
        var publicacao1 = new Publicacao(
            publicacao.UsuarioId, usuario, publicacao.Titulo, publicacao.Descricao,
            publicacao.Genero, publicacao.Duracao, publicacao.Tipo);

        try
        {
            publicacaoRepository.criarPublicacao(publicacao1);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
