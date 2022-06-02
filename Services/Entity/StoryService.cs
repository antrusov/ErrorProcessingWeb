using SqlKata.Execution;
using ErrorProcessingWeb.Models.Entity;

namespace ErrorProcessingWeb.Services.Entity;

public class StoryService
{
    private readonly QueryFactory _db;
    private readonly ILogger<StoryService> _logger;

    public StoryService(
        QueryFactory db,
        ILogger<StoryService> logger)
    {
        _db = db;
        _logger = logger;
    }

    public StoryEntity GetById(int Id) => _db.Query("Story").Where("Id", Id).FirstOrDefault<StoryEntity>();
    public IEnumerable<StoryEntity> GetAll() => _db.Query("Story").Get<StoryEntity>();
    public int Create(CreateStoryEntity story) => _db.Query("Story").InsertGetId<int>(story);
    public void Update(StoryEntity story) => _db.Query("Story").Where("Id", story.Id).Update(story);
    public void Delete(int Id) => _db.Query("Story").Where("Id", Id).Delete();
}