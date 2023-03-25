using FilmeAPI.Data;
using FilmeAPI.Models;

namespace FilmeAPI.Repositories;

public class InteracoesRepository
{
    private readonly FilmeDbContext _context;

    public InteracoesRepository(FilmeDbContext context)
    {
        _context = context;
    }

    public void criarInteracao(Interacao interacao)
    {
        _context.Interacoes.Add(interacao);
        _context.SaveChanges();
    }

    public IQueryable<Interacao> GetInteracoes()
    {
        return _context.Interacoes.AsQueryable();
    }
}
