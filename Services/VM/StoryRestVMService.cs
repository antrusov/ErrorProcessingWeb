using ErrorProcessingWeb.Services;

namespace ErrorProcessingWeb.Services.VM.REST;

public class StoryRestVMService
{
    private readonly ILogger<StoryRestVMService> _logger;

    public StoryRestVMService(
        ILogger<StoryRestVMService> logger)
    {
        _logger = logger;
    }

}