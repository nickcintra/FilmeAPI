using FilmeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeAPI.Data;

public class FilmeDbContext : DbContext
{
    public FilmeDbContext(DbContextOptions<FilmeDbContext> options) : base(options)
    {
        
    }


    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Publicacao> Publicacoes { get; set; }
    public DbSet<Interacao> Interacoes { get; set; }
}
