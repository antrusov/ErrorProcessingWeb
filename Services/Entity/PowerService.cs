using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class PowerEntityService
{
    private readonly QueryFactory _db;
    private readonly ILogger<PowerEntityService> _logger;

    public PowerEntityService(
        QueryFactory db,
        ILogger<PowerEntityService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<PowerEntity> GetById(int id) => await _db.Query("Power").Where("Id", id).FirstOrDefaultAsync<PowerEntity>();
    public async Task<IEnumerable<PowerEntity>> GetByHeroId(int heroId) => await _db.Query("Power").Where("HeroId", heroId).GetAsync<PowerEntity>();
    public async Task<IEnumerable<PowerEntity>> GetAll() => await _db.Query("Power").GetAsync<PowerEntity>();
    public async Task<int> Create(CreatePowerEntity power) => await _db.Query("Power").InsertGetIdAsync<int>(power);
    public async Task Update(UpdatePowerEntity power) => await _db.Query("Power").Where("Id", power.Id).UpdateAsync(power);
    public async Task Delete(int id) => await _db.Query("Power").Where("Id", id).DeleteAsync();
}