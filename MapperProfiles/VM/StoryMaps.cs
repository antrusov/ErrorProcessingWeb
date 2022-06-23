using AutoMapper;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.MapperProfiles.VM;

public class StoryMaps : Profile
{
    public StoryMaps()
    {
        CreateMap<StoryDto, StoryVM>();
        CreateMap<StoryDto, HeroStoryVM>();
        CreateMap<StoryDto, StoryListItemVM>();
    }
}