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

    public IEnumerable<ParticipationEntity> GetByHeroId(int heroId) => _db.Query("Participation").Where("HeroId", heroId).Get<ParticipationEntity>();
    public IEnumerable<ParticipationEntity> GetByStoryId(int storyId) => _db.Query("Participation").Where("StoryId", storyId).Get<ParticipationEntity>();
    public void Create(int heroId, int storyId) => _db.Query("Participation").Insert(new ParticipationEntity() { HeroId = heroId, StoryId = storyId });
    public void Delete(int heroId, int storyId) => _db.Query("Participation").Where(new ParticipationEntity() { HeroId = heroId, StoryId = storyId }).Delete();
    public void DeleteByHeroId(int heroId, int storyId) => _db.Query("Participation").Where("HeroId", heroId).Delete();
    public void DeleteByStoryId(int heroId, int storyId) => _db.Query("Participation").Where("StoryId", storyId).Delete();
}