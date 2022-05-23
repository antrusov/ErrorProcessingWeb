using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class ParticipationService
{
    private readonly QueryFactory _db;
    private readonly ILogger<ParticipationService> _logger;

    public ParticipationService(
        QueryFactory db,
        ILogger<ParticipationService> logger)
    {
        _db = db;
        _logger = logger;
    }

    //...
}