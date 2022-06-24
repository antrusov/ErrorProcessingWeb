using AutoMapper;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.MapperProfiles.VM;

public class PowerMaps : Profile
{
    public PowerMaps()
    {
        CreateMap<PowerDto, PowerVM>();
        CreateMap<PowerDto, HeroPowerVM>();
        CreateMap<PowerWithHeroIdDto, PowerVM>();
        CreateMap<PowerCreateVM, PowerWithHeroIdDto>();
        CreateMap<PowerUpdateVM, PowerDto>();
    }
}