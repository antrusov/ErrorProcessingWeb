using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class HeroService
{
    private readonly QueryFactory _db;
    private readonly ILogger<HeroService> _logger;

    public HeroService(
        QueryFactory db,
        ILogger<HeroService> logger)
    {
        _db = db;
        _logger = logger;
    }

    //...
}