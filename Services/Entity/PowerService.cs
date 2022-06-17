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

    public PowerEntity GetById(int Id) => _db.Query("Power").Where("Id", Id).FirstOrDefault<PowerEntity>();
    public IEnumerable<PowerEntity> GetAll() => _db.Query("Power").Get<PowerEntity>();
    public int Create(CreatePowerEntity power) => _db.Query("Power").InsertGetId<int>(power);
    public void Update(PowerEntity power) => _db.Query("Power").Where("Id", power.Id).Update(power);
    public void Delete(int Id) => _db.Query("Power").Where("Id", Id).Delete();
}