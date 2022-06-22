using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class ParticipationEntityService
{
    private readonly QueryFactory _db;
    private readonly ILogger<ParticipationEntityService> _logger;

    public ParticipationEntityService(
        QueryFactory db,
        ILogger<ParticipationEntityService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<IEnumerable<StoryEntity>> GetStoriesByHeroId(int heroId) => await _db.Query("Story").LeftJoin("Participation", j => j.On("Story.Id", "Participation.StoryId")).Where("HeroId", heroId).GetAsync<StoryEntity>();
    public async Task<IEnumerable<HeroEntity>> GetHeroesByStoryId(int storyId) => await _db.Query("Hero").LeftJoin("Participation", j => j.On("Hero.Id", "Participation.HeroId")).Where("StoryId", storyId).GetAsync<HeroEntity>();
    public async Task<IEnumerable<ParticipationEntity>> GetByHeroId(int heroId) => await _db.Query("Participation").Where("HeroId", heroId).GetAsync<ParticipationEntity>();
    public async Task<IEnumerable<ParticipationEntity>> GetByStoryId(int storyId) => await _db.Query("Participation").Where("StoryId", storyId).GetAsync<ParticipationEntity>();
    public async Task Create(int heroId, int storyId) => await _db.Query("Participation").InsertAsync(new ParticipationEntity() { HeroId = heroId, StoryId = storyId });
    public async Task Delete(int heroId, int storyId) => await _db.Query("Participation").Where(new ParticipationEntity() { HeroId = heroId, StoryId = storyId }).DeleteAsync();
    public async Task DeleteByHeroId(int heroId, int storyId) => await _db.Query("Participation").Where("HeroId", heroId).DeleteAsync();
    public async Task DeleteByStoryId(int heroId, int storyId) => await _db.Query("Participation").Where("StoryId", storyId).DeleteAsync();
}