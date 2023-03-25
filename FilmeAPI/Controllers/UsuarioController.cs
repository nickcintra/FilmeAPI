using AutoMapper;
using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Requests;
using FilmeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    private FilmeDbContext _context;
    private IMapper _mapper;
    private UsuarioService _service;

    public UsuarioController(FilmeDbContext context, IMapper mapper)
    {
        _service = new UsuarioService(context);
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CadastrarUsuario([FromBody] UsuarioRequest usuario)
    {
        bool usuarioRetorno = _service.criarUsuario(usuario);
        if (usuarioRetorno)
        {
            return Ok("Usuário criado com sucesso!");
        }
        else
        {
            return BadRequest("Falha ao criar usuário");
        }
    }

    [HttpPost("Login")]
    public IActionResult Login([FromBody] UsuarioRequest usuario)
    {

        Usuario usuarioRetorno = _service.login(usuario.Email, usuario.Senha);
        if (usuarioRetorno != null)
        {
            return Ok(new
            {
                mensagem = "Usuário logado com sucesso!",
                logado = true,
                usuario = usuarioRetorno
            });
        }
        else
        {
            return BadRequest("Falha ao autenticar usuario!");
        }
    }

    [HttpGet]
    public IActionResult ConsultarUsuarios() 
    {
        var results = _service.GetUsuarios();
         if (results != null)
        {
            return Ok(results);
        }
        else
        {
            return BadRequest("Nenhuma usuário encontrado");
        }
    }

    [HttpGet("{id}")]
    public IActionResult ConsultarUsuarioUnico(int id)
    {
        Usuario usuario = _service.GetUsuarioUnico(id);
        if (usuario != null)
        {
            return Ok(usuario);
        }
        else
        {
            return BadRequest("Nenhuma usuário encontrado");
        }
        

    }

}