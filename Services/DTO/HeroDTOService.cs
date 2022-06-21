using AutoMapper;
using ErrorProcessingWeb.Services.Entity;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.DTO;

namespace ErrorProcessingWeb.Services.DTO;

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

    //...

}
