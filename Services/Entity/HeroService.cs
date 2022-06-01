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

    public HeroEntity GetById(int Id) => _db.Query("Hero").Where("Id", Id).FirstOrDefault<HeroEntity>();
    public IEnumerable<HeroEntity> GetAll() => _db.Query("Hero").Get<HeroEntity>();
    public int Create(CreateHeroEntity hero) => _db.Query("Hero").InsertGetId<int>(hero);
    public void Update(HeroEntity hero) => _db.Query("Hero").Where("Id", hero.Id).Update(hero);
    public void Delete(int Id) => _db.Query("Hero").Where("Id", Id).Delete();
}