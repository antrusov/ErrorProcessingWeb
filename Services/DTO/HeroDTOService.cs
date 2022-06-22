using AutoMapper;
using ErrorProcessingWeb.Services.Entity;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.Dto;

namespace ErrorProcessingWeb.Services.Dto;

public class HeroDtoService
{
    private readonly IMapper _mapper;
    private readonly HeroEntityService _heroEntityService;
    private readonly ILogger<HeroDtoService> _logger;

    public HeroDtoService(
        IMapper mapper,
        HeroEntityService heroEntityService,
        ILogger<HeroDtoService> logger)
    {
        _mapper = mapper;
        _heroEntityService = heroEntityService;
        _logger = logger;
    }

    public async Task<IEnumerable<HeroDto>> GetAll() =>
        _mapper.Map<IEnumerable<HeroDto>>(await _heroEntityService.GetAll());

    public async Task<HeroDto> Get(int id) =>
        _mapper.Map<HeroDto>(await _heroEntityService.GetById(id));

    public async Task<int> Create(HeroDto hero) =>
        await _heroEntityService.Create(_mapper.Map<CreateHeroEntity>(hero));

    public async Task Update(HeroDto hero) =>
        await _heroEntityService.Update(_mapper.Map<HeroEntity>(hero));

    public async Task Delete(int id) =>
        await _heroEntityService.Delete(id);
}
