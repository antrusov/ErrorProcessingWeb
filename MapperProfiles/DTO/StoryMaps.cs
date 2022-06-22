using AutoMapper;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.MapperProfiles.Dto;

public class StoryMaps : Profile
{
    public StoryMaps()
    {
        CreateMap<StoryEntity, StoryDto>();
        CreateMap<StoryDto, CreateStoryEntity>();
    }
}