using AutoMapper;
using ErrorProcessingWeb.Services.Dto;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.Services.VM.REST;

public class StoryRestVMService
{
    private readonly IMapper _mapper;
    private readonly StoryDtoService _storyDtoService;
    private readonly ILogger<StoryRestVMService> _logger;

    public StoryRestVMService(
        IMapper mapper,
        StoryDtoService storyDtoService,
        ILogger<StoryRestVMService> logger)
    {
        _mapper = mapper;
        _storyDtoService = storyDtoService;
        _logger = logger;
    }

    public async Task<IEnumerable<StoryListItemVM>> GetAll()
        => _mapper.Map<IEnumerable<StoryListItemVM>>(await _storyDtoService.GetAll());

    public async Task<IEnumerable<StoryListItemVM>> GetByHeroId(int heroId)
        => _mapper.Map<IEnumerable<StoryListItemVM>>(await _storyDtoService.GetByHeroId(heroId));

    //todo link/unlink

    public async Task<StoryVM> Get(int id)
        => _mapper.Map<StoryVM>(await _storyDtoService.Get(id));

    public async Task<StoryWithExtrasVM> GetWithExtras(int id)
        => _mapper.Map<StoryWithExtrasVM>(await _storyDtoService.GetWithExtras(id));

    public async Task<int> Create(StoryCreateVM storyCreate)
        => await _storyDtoService.Create(_mapper.Map<StoryDto>(storyCreate));

    //todo: отвязать героев
    public async Task Delete(int id)
        => await _storyDtoService.Delete(id);

    public async Task Update(StoryUpdateVM storyUpdate)
        => await _storyDtoService.Update(_mapper.Map<StoryDto>(storyUpdate));
}