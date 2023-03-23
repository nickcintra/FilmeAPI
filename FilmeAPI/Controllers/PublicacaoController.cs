using AutoMapper;
using FilmeAPI.Data;
using FilmeAPI.Data.Dtos;
using FilmeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PublicacaoController : ControllerBase
{
    private FilmeDbContext _context;
    private IMapper _mapper;

    public PublicacaoController(FilmeDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CriarPublicacao([FromBody] CreatePublicacaoDto createPublicacaoDto)
    {
        Publicacao publicacao = _mapper.Map<Publicacao>(createPublicacaoDto);
        _context.Publicacoes.Add(publicacao);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ConsultarPublicacaoUnica),
        new { id = publicacao.Id }, publicacao);
    }

    [HttpGet]
    public IEnumerable<Publicacao> ConsultarPublicacoes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Publicacoes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult ConsultarPublicacaoUnica(int id)
    {
        var publicacao = _context.Publicacoes.FirstOrDefault(publicacao => publicacao.Id == id);
        if (publicacao == null) return NotFound();
        return Ok(publicacao);

    }

}
