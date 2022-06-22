using AutoMapper;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.DTO;

namespace ErrorProcessingWeb.MapperProfiles.DTO;

public class HeroMaps : Profile
{
    public HeroMaps()
    {
        CreateMap<HeroEntity, HeroDto>();
        CreateMap<HeroDto, CreateHeroEntity>();
    }
}