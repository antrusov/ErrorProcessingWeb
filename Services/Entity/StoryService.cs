using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class StoryService
{
    private readonly QueryFactory _db;
    private readonly ILogger<StoryService> _logger;

    public StoryService(
        QueryFactory db,
        ILogger<StoryService> logger)
    {
        _db = db;
        _logger = logger;
    }

    //...
}