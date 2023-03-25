using FilmeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace FilmeAPI.Data;

public class FilmeDbContext : DbContext
{
    public FilmeDbContext(DbContextOptions<FilmeDbContext> options) : base(options)
    {

    }

    #region Required
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //relacões usuario
        modelBuilder
            .Entity<Usuario>()
            .HasMany(u => u.publicacoes)
            .WithOne(p => p.usuario)
            .HasForeignKey(p => p.UsuarioId);

        modelBuilder
           .Entity<Usuario>()
           .HasMany(u => u.interacoes)
           .WithOne(i => i.usuario)
           .HasForeignKey(i => i.UsuarioId);

        // relações publicação
        modelBuilder
            .Entity<Publicacao>()
            .HasOne(p => p.usuario)
            .WithMany(u => u.publicacoes);

        modelBuilder
            .Entity<Publicacao>()
            .HasMany(p => p.Interacoes)
            .WithOne(i => i.publicacao)
            .HasForeignKey(i => i.PublicacaoId);

        // relações interações
        modelBuilder
            .Entity<Interacao>()
            .HasOne(i => i.usuario)
            .WithMany(u => u.interacoes);

        modelBuilder
            .Entity<Interacao>()
            .HasOne(i => i.publicacao)
            .WithMany(p => p.Interacoes);
    }
    #endregion


    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Publicacao> Publicacoes { get; set; }
    public DbSet<Interacao> Interacoes { get; set; }
    public DbSet<TipoInteracao> TipoInteracao { get; set; }
}
