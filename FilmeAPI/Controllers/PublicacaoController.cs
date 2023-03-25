using AutoMapper;
using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Requests;
using FilmeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PublicacaoController : ControllerBase
{
    private PublicacaoService _service;
    private FilmeDbContext _context;
    private IMapper _mapper;

    public PublicacaoController(FilmeDbContext context, IMapper mapper)
    {
        _service = new PublicacaoService(context);
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CriarPublicacao([FromBody] PublicacaoRequest publicacao)
    {
        bool usuarioRetorno = _service.criarPublicacao(publicacao);
        if (usuarioRetorno)
        {
            return Ok("Publicação criado com sucesso!");
        }
        else
        {
            return BadRequest("Falha ao criar publicação");
        }
    }

    [HttpGet]
    public IActionResult ConsultarPublicacoes()
    {
        var results = _service.GetPublicacoes();
        if (results != null)
        {
            return Ok(results);
        }
        else
        {
            return BadRequest("Nenhuma publicação encontrada");
        }
    }

    [HttpGet("{id}")]
    public IActionResult ConsultarPublicacaoUnica(int id)
    {
        var publicacao = _service.GetPublicacoesPorUsuario(id);
        if (publicacao == null) return NotFound();
        return Ok(publicacao);

    }

    //[HttpGet]
    //public IEnumerable<Publicacao> ConsultarPublicacoes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    //{
    //    return _context.Publicacoes.Skip(skip).Take(take);
    //}

}
