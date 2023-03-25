using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Requests;

namespace FilmeAPI.Repositories;

public class PublicacaoRepository
{
    private readonly FilmeDbContext _context;

    public PublicacaoRepository(FilmeDbContext context)
    {
        _context = context;
    }

    public void criarPublicacao(Publicacao publicacao)
    {
        _context.Publicacoes.Add(publicacao);
        _context.SaveChanges();
    }

    public IQueryable<Publicacao> GetPublicacoes()
    {
        return _context.Publicacoes.AsQueryable();
    }
}
