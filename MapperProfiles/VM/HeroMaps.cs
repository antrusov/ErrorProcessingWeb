using AutoMapper;
using ErrorProcessingWeb.Models.DTO;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.MapperProfiles.VM;

public class HeroMaps : Profile
{
    public HeroMaps()
    {
        CreateMap<HeroDto, HeroVM>();
    }
}