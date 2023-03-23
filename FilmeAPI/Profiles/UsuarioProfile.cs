using AutoMapper;
using FilmeAPI.Data.Dtos;
using FilmeAPI.Models;

namespace FilmeAPI.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile() 
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
