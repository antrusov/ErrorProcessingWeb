using AutoMapper;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.Dto;

namespace ErrorProcessingWeb.MapperProfiles.Dto;

public class HeroMaps : Profile
{
    public HeroMaps()
    {
        CreateMap<HeroEntity, HeroDto>();
        CreateMap<HeroEntity, HeroWithExtrasDto>();
        CreateMap<HeroDto, CreateHeroEntity>();
        CreateMap<HeroDto, HeroEntity>();
    }
}