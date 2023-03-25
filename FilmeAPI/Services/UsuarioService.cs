using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Repositories;
using FilmeAPI.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmeAPI.Services;

public class UsuarioService
{
    private readonly UsuarioRepository usuarioRespository;

    public UsuarioService(FilmeDbContext context)
    {
        usuarioRespository = new UsuarioRepository(context);
    }

    public IQueryable GetUsuarios()
    {
        return usuarioRespository.GetUsuarios();
    }

    public Usuario GetUsuarioUnico(int id)
    {
        return usuarioRespository.GetUsuarioUnico(id);

    }

    public Usuario login(string email, string senha)
    {
        Usuario usuario = usuarioRespository.getUserByEmail(email);
        if (usuario != null)
        {
            return null;
        }
        if (usuario.email == email && usuario.senha == senha)
        {
            return usuario;
        }
        return null;
    }

    public bool criarUsuario(UsuarioRequest usuario)
    {
        try
        {
            usuarioRespository.criarUsuario(usuario);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


}
