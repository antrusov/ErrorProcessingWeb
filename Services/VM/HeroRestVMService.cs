using ErrorProcessingWeb.Services;

namespace ErrorProcessingWeb.Services.VM;

public class HeroRestVMService
{
    private readonly ILogger<HeroRestVMService> _logger;

    public HeroRestVMService(
        ILogger<HeroRestVMService> logger)
    {
        _logger = logger;
    }

}