using AutoMapper;
using FilmeAPI.Data;
using FilmeAPI.Models;
using FilmeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoInteracaoController : ControllerBase
{
    private FilmeDbContext _context;
    private IMapper _mapper;
    private InteracaoService _service;

    public TipoInteracaoController(FilmeDbContext context, IMapper mapper)
    {
        _service = new InteracaoService(context);
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public IActionResult ConsultarTipoInteracao(int id)
    {
        TipoInteracao tipoInteracao = _service.GetTipoInteracao(id);

        if (tipoInteracao != null)
        {
            return Ok(tipoInteracao);
        }
        else
        {
            return BadRequest("Nenhuma usuário encontrado");
        }


    }
}
