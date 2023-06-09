using AutoMapper;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dto;

namespace LevvaCoins.Logic.MapperProfiles
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
          CreateMap<UsuarioDto, Usuario>().ReverseMap();
          CreateMap<TransacaoDto, Transacao>().ReverseMap();
          CreateMap<CategoriaDto, Categoria>().ReverseMap();
        }
    }
}
