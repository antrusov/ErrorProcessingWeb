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
    }
}