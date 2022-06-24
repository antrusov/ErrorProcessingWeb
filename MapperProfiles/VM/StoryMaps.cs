using AutoMapper;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.MapperProfiles.VM;

public class StoryMaps : Profile
{
    public StoryMaps()
    {
        CreateMap<StoryDto, StoryVM>();
        CreateMap<StoryDto, StoryListItemVM>();
        CreateMap<StoryDto, StoryWithExtrasVM>();
        CreateMap<StoryWithExtrasDto, StoryWithExtrasVM>();
        CreateMap<StoryDto, HeroStoryVM>();
        CreateMap<StoryCreateVM, StoryDto>();
        CreateMap<StoryUpdateVM, StoryDto>();
    }
}