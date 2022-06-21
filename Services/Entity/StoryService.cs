using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class StoryEntityService
{
    private readonly QueryFactory _db;
    private readonly ILogger<StoryEntityService> _logger;

    public StoryEntityService(
        QueryFactory db,
        ILogger<StoryEntityService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<StoryEntity> GetById(int Id) => await _db.Query("Story").Where("Id", Id).FirstOrDefaultAsync<StoryEntity>();
    public async Task<IEnumerable<StoryEntity>> GetAll() => await _db.Query("Story").GetAsync<StoryEntity>();
    public async Task<int> Create(CreateStoryEntity story) => await _db.Query("Story").InsertGetIdAsync<int>(story);
    public async Task Update(StoryEntity story) => await _db.Query("Story").Where("Id", story.Id).UpdateAsync(story);
    public async Task Delete(int Id) => await _db.Query("Story").Where("Id", Id).DeleteAsync();
}