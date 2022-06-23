using AutoMapper;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.MapperProfiles.Dto;

public class PowerMaps : Profile
{
    public PowerMaps()
    {
        CreateMap<PowerEntity, PowerDto>();
        CreateMap<PowerWithHeroIdDto, CreatePowerEntity>();
        CreateMap<PowerDto, UpdatePowerEntity>();
    }
}