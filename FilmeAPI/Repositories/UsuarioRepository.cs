using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Requests;
using System.Linq;

namespace FilmeAPI.Repositories;

public class UsuarioRepository
{
    private readonly FilmeDbContext _context;

    public UsuarioRepository(FilmeDbContext context)
    {
        _context = context;
    }

    public void criarUsuario(UsuarioRequest usuario)
    {
        var usuario1 = new Usuario(usuario.Email, usuario.Senha);
        _context.Usuarios.Add(usuario1);
        _context.SaveChanges();
    }

    public Usuario getUserByEmail(string email)
    {
        return _context.Usuarios.Where(w => w.email == email).FirstOrDefault();
    }

    public IQueryable<Usuario> GetUsuarios()
    {
        return _context.Usuarios.AsQueryable();
    }

    public Usuario GetUsuarioUnico(int id)
    {
        return _context.Usuarios.FirstOrDefault(usuario => usuario.id == id);
    }
}
