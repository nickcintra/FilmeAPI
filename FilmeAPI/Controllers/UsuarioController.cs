using AutoMapper;
using FilmeAPI.Data;
using FilmeAPI.Data.Dtos;
using FilmeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    private FilmeDbContext _context;
    private IMapper _mapper;

    public UsuarioController(FilmeDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CadastrarUsuario([FromBody] CreateUsuarioDto usuarioDto)
    {
        Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ConsultarUsuarioUnico),
        new { id = usuario.Id }, usuario);
    }

    [HttpGet]
    public IEnumerable<Usuario> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Usuarios.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult ConsultarUsuarioUnico(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
        if (usuario == null) return NotFound();
        return Ok(usuario);

    }
}