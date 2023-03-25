using FilmeAPI.Data;
using FilmeAPI.Models;
using System;

namespace FilmeAPI.Repositories;

public class InteracoesRepository
{
    private readonly FilmeDbContext _context;

    public InteracoesRepository(FilmeDbContext context)
    {
        _context = context;
    }

    public TipoInteracao GetTipoInteracao(int id)
    {

        return _context.TipoInteracao.FirstOrDefault(tipoInteracao => tipoInteracao.id == id);
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
