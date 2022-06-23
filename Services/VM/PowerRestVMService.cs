using AutoMapper;
using ErrorProcessingWeb.Services.Dto;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.Services.VM.REST;

public class PowerRestVMService
{
    private readonly IMapper _mapper;
    private readonly PowerDtoService _powerDtoService;
    private readonly ILogger<PowerRestVMService> _logger;

    public PowerRestVMService(
        IMapper mapper,
        PowerDtoService powerDtoService,
        ILogger<PowerRestVMService> logger)
    {
        _mapper = mapper;
        _powerDtoService = powerDtoService;
        _logger = logger;
    }

    public async Task<IEnumerable<PowerVM>> GetAll()
        => _mapper.Map<IEnumerable<PowerVM>>(await _powerDtoService.GetAll());

    public async Task<IEnumerable<HeroPowerVM>> GetByHeroId(int heroId)
        => _mapper.Map<IEnumerable<HeroPowerVM>>(await _powerDtoService.GetByHeroId(heroId)); //todo

    public async Task<PowerVM> Get(int id)
        => _mapper.Map<PowerVM>(await _powerDtoService.Get(id));

    public async Task<int> Create(PowerCreateVM powerCreate)
        => await _powerDtoService.Create(_mapper.Map<PowerWithHeroIdDto>(powerCreate));

    public async Task Delete(int id)
        => await _powerDtoService.Delete(id);

    public async Task Update(PowerUpdateVM powerUpdate)
        => await _powerDtoService.Update(_mapper.Map<PowerDto>(powerUpdate));
}