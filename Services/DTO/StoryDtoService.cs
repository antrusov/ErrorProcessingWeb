using AutoMapper;
using ErrorProcessingWeb.Services.Entity;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.Dto;

namespace ErrorProcessingWeb.Services.Dto;

public class StoryDtoService
{
    private readonly IMapper _mapper;
    private readonly StoryEntityService _storyEntityService;
    private readonly ILogger<StoryDtoService> _logger;

    public StoryDtoService(
        IMapper mapper,
        StoryEntityService storyEntityService,
        ILogger<StoryDtoService> logger)
    {
        _mapper = mapper;
        _storyEntityService = storyEntityService;
        _logger = logger;
    }

    public async Task<IEnumerable<StoryDto>> GetAll() =>
        _mapper.Map<IEnumerable<StoryDto>>(await _storyEntityService.GetAll());

    public async Task<StoryDto> Get(int id) =>
        _mapper.Map<StoryDto>(await _storyEntityService.GetById(id));

    public async Task<int> Create(StoryDto story) =>
        await _storyEntityService.Create(_mapper.Map<CreateStoryEntity>(story));

    public async Task Update(StoryDto story) =>
        await _storyEntityService.Update(_mapper.Map<StoryEntity>(story));

    public async Task Delete(int id) =>
        await _storyEntityService.Delete(id);
}
