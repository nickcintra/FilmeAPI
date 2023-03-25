using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Repositories;

namespace FilmeAPI.Services;

public class InteracaoService
{
    private readonly InteracoesRepository interacoesRepository;

    public InteracaoService(FilmeDbContext filmeDbContext)
    {
        interacoesRepository = new InteracoesRepository(filmeDbContext);
    }

    public IQueryable GetInteracoes()
    {
        return interacoesRepository.GetInteracoes();
    }

    public bool criarInteracao(Interacao interacao)
    {
        try
        {
            interacoesRepository.criarInteracao(interacao);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
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
