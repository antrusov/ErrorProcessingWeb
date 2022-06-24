using Microsoft.AspNetCore.Mvc;
using ErrorProcessingWeb.Models.VM;
using ErrorProcessingWeb.Models.VM.REST;
using ErrorProcessingWeb.Services.VM.REST;

namespace ErrorProcessingWeb.Controllers;

[ApiController]
[Route("rest/[controller]")]
public class StoryController : ControllerBase
{
    private readonly StoryRestVMService _storyRestVMService;
    private readonly ILogger<StoryController> _logger;

    public StoryController(
        StoryRestVMService storyRestVMService,
        ILogger<StoryController> logger)
    {
        _storyRestVMService = storyRestVMService;
        _logger = logger;
    }

    /// <summary>
    /// Получить список историй.
    /// </summary>
    /// <returns>Список историй.</returns>
    [HttpGet("get-list")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<StoryListItemVM>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<IEnumerable<HeroListItemVM>>> GetList ()
        => Ok(await _storyRestVMService.GetAll());

    /// <summary>
    /// Получить историю.
    /// </summary>
    /// <returns>История.</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StoryVM))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<StoryVM>> Get (int id)
        => Ok(await _storyRestVMService.Get(id));

    /// <summary>
    /// Получить историю с дополнительными данными.
    /// </summary>
    /// <returns>История c дополнительными данными.</returns>
    [HttpGet("get-with-extras/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StoryWithExtrasVM))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<StoryWithExtrasVM>> GetWithExtras (int id)
        => Ok(await _storyRestVMService.GetWithExtras(id));

    //todo link/unlink

    /// <summary>
    /// Создать историю.
    /// </summary>
    /// <returns>Идентификатор созданной истории.</returns>
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<int>> Create (StoryCreateVM storyCreate)
        => Ok(await _storyRestVMService.Create(storyCreate));

    /// <summary>
    /// Изменить историю.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult> Update (StoryUpdateVM storyUpdate)
    {
        await _storyRestVMService.Update(storyUpdate);
        return NoContent();
    }

    /// <summary>
    /// Удалить историю.
    /// </summary>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult> Delete (int id)
    {
        await _storyRestVMService.Delete(id);
        return NoContent();
    }
}
