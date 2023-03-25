using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Repositories;
using FilmeAPI.Requests;

namespace FilmeAPI.Services;

public class InteracaoService
{
    private readonly InteracoesRepository interacoesRepository;
    private readonly UsuarioRepository usuarioRepository;
    private readonly PublicacaoRepository publicacaoRepository;
    public InteracaoService(FilmeDbContext filmeDbContext)
    {
        interacoesRepository = new InteracoesRepository(filmeDbContext);
        usuarioRepository = new UsuarioRepository(filmeDbContext);
        publicacaoRepository = new PublicacaoRepository(filmeDbContext);    
    }

    public IQueryable GetInteracoes()
    {
        return interacoesRepository.GetInteracoes();
    }

    public bool criarInteracao(InteracaoRequest interacao)
    {
        Publicacao publicacao = publicacaoRepository.GetPublicacaoUnica(interacao.PublicacaoId);
        Usuario usuario = usuarioRepository.GetUsuarioUnico(interacao.UsuarioId);
        TipoInteracao tipoInteracao = GetTipoInteracao(interacao.tipoInteracao);

        Interacao interacao1 = new Interacao(interacao.UsuarioId, tipoInteracao, usuario, publicacao, interacao.PublicacaoId);
        try
        {
            interacoesRepository.criarInteracao(interacao1);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public TipoInteracao GetTipoInteracao(int id)
    {
        return interacoesRepository.GetTipoInteracao(id);
    }

    //public IQueryable GetPublicacoesPorUsuario(int idUsuario)
    //{
    //    return publicacaoRepository.GetPublicacoes()
    //            .Join(
    //                interacoesRepository.GetInteracoes(),
    //                publicacao => publicacao.Id,
    //                interacao => interacao.Id,
    //                (publicacao, interacao) =>
    //                new
    //                {
    //                    idPublicacao = publicacao.Id,
    //                    idUsuario = publicacao.IdUsuario,

    //                }).Where(w => w.idUsuario == idUsuario);
    //}
}
