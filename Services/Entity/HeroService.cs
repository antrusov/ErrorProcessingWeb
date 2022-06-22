using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class HeroEntityService
{
    private readonly QueryFactory _db;
    private readonly ILogger<HeroEntityService> _logger;

    public HeroEntityService(
        QueryFactory db,
        ILogger<HeroEntityService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<HeroEntity> GetById(int id) => await _db.Query("Hero").Where("Id", id).FirstOrDefaultAsync<HeroEntity>();
    public async Task<IEnumerable<HeroEntity>> GetAll() => await _db.Query("Hero").GetAsync<HeroEntity>();
    public async Task<int> Create(CreateHeroEntity hero) => await _db.Query("Hero").InsertGetIdAsync<int>(hero);
    public async Task Update(HeroEntity hero) => await _db.Query("Hero").Where("Id", hero.Id).UpdateAsync(hero);
    public async Task Delete(int id) => await _db.Query("Hero").Where("Id", id).DeleteAsync();
}