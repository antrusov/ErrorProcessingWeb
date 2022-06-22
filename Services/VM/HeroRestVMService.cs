using AutoMapper;
using ErrorProcessingWeb.Services.Dto;
using ErrorProcessingWeb.Models.Dto;
using ErrorProcessingWeb.Models.VM.REST;

namespace ErrorProcessingWeb.Services.VM.REST;

public class HeroRestVMService
{
    private readonly IMapper _mapper;
    private readonly HeroDtoService _heroDtoService;
    private readonly ILogger<HeroRestVMService> _logger;

    public HeroRestVMService(
        IMapper mapper,
        HeroDtoService heroDtoService,
        ILogger<HeroRestVMService> logger)
    {
        _mapper = mapper;
        _heroDtoService = heroDtoService;
        _logger = logger;
    }

    public async Task<IEnumerable<HeroListItemVM>> GetAll()
        => _mapper.Map<IEnumerable<HeroListItemVM>>(await _heroDtoService.GetAll());

    //...

}