using ErrorProcessingWeb.Services;

namespace ErrorProcessingWeb.Services.VM;

public class PowerRestVMService
{
    private readonly ILogger<PowerRestVMService> _logger;

    public PowerRestVMService(
        ILogger<PowerRestVMService> logger)
    {
        _logger = logger;
    }

}