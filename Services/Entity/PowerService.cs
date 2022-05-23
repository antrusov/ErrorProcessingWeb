using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class PowerService
{
    private readonly QueryFactory _db;
    private readonly ILogger<PowerService> _logger;

    public PowerService(
        QueryFactory db,
        ILogger<PowerService> logger)
    {
        _db = db;
        _logger = logger;
    }

    //...
}