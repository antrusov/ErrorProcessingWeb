using ErrorProcessingWeb.Services.Entity;

namespace ErrorProcessingWeb.Services.DTO;

public class HeroDTOService
{
    private readonly ILogger<HeroDTOService> _logger;

    public HeroDTOService(
        ILogger<HeroDTOService> logger)
    {
        _logger = logger;
    }

}
