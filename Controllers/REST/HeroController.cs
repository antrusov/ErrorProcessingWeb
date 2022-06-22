using Microsoft.AspNetCore.Mvc;
using ErrorProcessingWeb.Models.VM;
using ErrorProcessingWeb.Models.VM.REST;
using ErrorProcessingWeb.Services.VM.REST;

namespace ErrorProcessingWeb.Controllers;

[ApiController]
[Route("rest/[controller]")]
public class HeroController : ControllerBase
{
    private readonly HeroRestVMService _heroRestVMService;
    private readonly ILogger<HeroController> _logger;

    public HeroController(
        HeroRestVMService heroRestVMService,
        ILogger<HeroController> logger)
    {
        _heroRestVMService = heroRestVMService;
        _logger = logger;
    }

    /// <summary>
    /// Получить список супергероев.
    /// </summary>
    /// <returns>Список супергероев.</returns>
    [HttpGet("get-list")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<HeroListItemVM>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<IEnumerable<HeroListItemVM>>> GetList ()
        => Ok(await _heroRestVMService.GetAll());

    /// <summary>
    /// Получить супергероя.
    /// </summary>
    /// <returns>Супергерой.</returns>
    [HttpGet("get/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HeroVM))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<HeroVM>> Get (int id)
        => Ok(await _heroRestVMService.Get(id));

    /// <summary>
    /// Получить супергероя с дополнительными данными.
    /// </summary>
    /// <returns>Супергерой c дополнительными данными.</returns>
    [HttpGet("get-with-extras/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(HeroVM))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<HeroVM>> GetWithExtras (int id)
        => Ok(await _heroRestVMService.GetWithExtras(id));

    //Update
    //Delete
    //Create
}
