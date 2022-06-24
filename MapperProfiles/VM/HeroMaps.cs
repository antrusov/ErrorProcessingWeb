using AutoMapper;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.MapperProfiles.VM;

public class HeroMaps : Profile
{
    public HeroMaps()
    {
        CreateMap<HeroDto, HeroVM>();
        CreateMap<HeroDto, HeroListItemVM>();
        CreateMap<HeroDto, HeroWithExtrasVM>();
        CreateMap<HeroWithExtrasDto, HeroWithExtrasVM>();
        CreateMap<HeroCreateVM, HeroDto>();
        CreateMap<HeroUpdateVM, HeroDto>();
    }
}