using AutoMapper;
using ErrorProcessingWeb.Services.Entity;
using ErrorProcessingWeb.Models.Entity;
using ErrorProcessingWeb.Models.Dto;

namespace ErrorProcessingWeb.Services.Dto;

public class PowerDtoService
{
    private readonly IMapper _mapper;
    private readonly PowerEntityService _powerEntityService;
    private readonly ILogger<PowerDtoService> _logger;

    public PowerDtoService(
        IMapper mapper,
        PowerEntityService powerEntityService,
        ILogger<PowerDtoService> logger)
    {
        _mapper = mapper;
        _powerEntityService = powerEntityService;
        _logger = logger;
    }

    public async Task<IEnumerable<PowerDto>> GetAll() =>
        _mapper.Map<IEnumerable<PowerDto>>(await _powerEntityService.GetAll());

    public async Task<IEnumerable<PowerDto>> GetByHeroId(int heroId) =>
        _mapper.Map<IEnumerable<PowerDto>>(await _powerEntityService.GetByHeroId(heroId));

    public async Task<PowerDto> Get(int id) =>
        _mapper.Map<PowerDto>(await _powerEntityService.GetById(id));

    public async Task<int> Create(PowerWithHeroIdDto power) =>
        await _powerEntityService.Create(_mapper.Map<CreatePowerEntity>(power));

    public async Task Update(PowerDto power) =>
        await _powerEntityService.Update(_mapper.Map<UpdatePowerEntity>(power));

    public async Task Delete(int id) =>
        await _powerEntityService.Delete(id);
}
