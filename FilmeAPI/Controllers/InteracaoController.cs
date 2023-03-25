using AutoMapper;
using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class InteracaoController : ControllerBase
{
    private InteracaoService _service;
    private FilmeDbContext _context;
    private IMapper _mapper;

    public InteracaoController(FilmeDbContext context, IMapper mapper)
    {
        _service = new InteracaoService(context);
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CriarPublicacao([FromBody] Interacao interacao)
    {

        bool usuarioRetorno = _service.criarInteracao(interacao);
        if (usuarioRetorno)
        {
            return Ok("Publicação criado com sucesso!");
        }
        else
        {
            return BadRequest("Falha ao criar publicação");
        }
    }

    //[HttpGet]
    //public IEnumerable<Publicacao> ConsultarPublicacoes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    //{
    //    return _context.Publicacoes.Skip(skip).Take(take);
    //}

    [HttpGet]
    public IActionResult ConsultarInteracoes()
    {
        var results = _service.GetInteracoes();
        if (results != null)
        {
            return Ok(results);
        }
        else
        {
            return BadRequest("Nenhuma publicação encontrada");
        }
    }

    //[HttpPut("{id}")]

    //[HttpGet("{id}")]
    //public IActionResult ConsultarInteracao(int id)
    //{
    //    var publicacao = _service.GetPublicacoesPorUsuario(id);
    //    if (publicacao == null) return NotFound();
    //    return Ok(publicacao);

    //}

}
