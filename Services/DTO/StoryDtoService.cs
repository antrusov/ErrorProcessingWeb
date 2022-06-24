using AutoMapper;
using ErrorProcessingWeb.Services.Entity;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.Dto;

namespace ErrorProcessingWeb.Services.Dto;

public class StoryDtoService
{
    private readonly IMapper _mapper;
    private readonly PowerEntityService _powerEntityService;
    private readonly StoryEntityService _storyEntityService;
    private readonly ParticipationEntityService _participationEntityService;
    private readonly ILogger<StoryDtoService> _logger;

    public StoryDtoService(
        IMapper mapper,
        PowerEntityService powerEntityService,
        StoryEntityService storyEntityService,
        ParticipationEntityService participationEntityService,
        ILogger<StoryDtoService> logger)
    {
        _mapper = mapper;
        _powerEntityService = powerEntityService;
        _storyEntityService = storyEntityService;
        _participationEntityService = participationEntityService;
        _logger = logger;
    }

    public async Task<IEnumerable<StoryDto>> GetAll() =>
        _mapper.Map<IEnumerable<StoryDto>>(await _storyEntityService.GetAll());

    public async Task<IEnumerable<StoryDto>> GetByHeroId(int heroId) =>
        _mapper.Map<IEnumerable<StoryDto>>(await _participationEntityService.GetStoriesByHeroId(heroId));

    public async Task<StoryDto> Get(int id) =>
        _mapper.Map<StoryDto>(await _storyEntityService.GetById(id));

    public async Task<StoryWithExtrasDto> GetWithExtras(int id)
    {
        var storyWithExtras = _mapper.Map<StoryWithExtrasDto>(await _storyEntityService.GetById(id));
        storyWithExtras.Heroes = _mapper.Map<IEnumerable<HeroDto>>(await _participationEntityService.GetHeroesByStoryId(id));
        storyWithExtras.Powers = _mapper.Map<IEnumerable<PowerWithHeroIdDto>>(await _powerEntityService.GetByHeroIds(
            storyWithExtras.Heroes.Select(hero => hero.Id)
        ));
        return storyWithExtras;
    }

    public async Task<int> Create(StoryDto story) =>
        await _storyEntityService.Create(_mapper.Map<CreateStoryEntity>(story));

    public async Task Update(StoryDto story) =>
        await _storyEntityService.Update(_mapper.Map<StoryEntity>(story));

    public async Task Delete(int id) =>
        await _storyEntityService.Delete(id);
}
