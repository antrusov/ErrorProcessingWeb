using Microsoft.AspNetCore.Mvc;
using ErrorProcessingWeb.Models.VM;
using ErrorProcessingWeb.Models.VM.REST;
using ErrorProcessingWeb.Services.VM.REST;

namespace ErrorProcessingWeb.Controllers;

[ApiController]
[Route("rest/[controller]")]
public class PowerController : ControllerBase
{
    private readonly PowerRestVMService _powerRestVMService;
    private readonly ILogger<PowerController> _logger;

    public PowerController(
        PowerRestVMService powerRestVMService,
        ILogger<PowerController> logger)
    {
        _powerRestVMService = powerRestVMService;
        _logger = logger;
    }

    /// <summary>
    /// Получить полный список суперсил.
    /// </summary>
    /// <returns>Список суперсил.</returns>
    [HttpGet("get-list")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PowerVM>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<IEnumerable<PowerVM>>> GetList ()
        => Ok(await _powerRestVMService.GetAll());

    /// <summary>
    /// Получить список суперсил для конкретного героя.
    /// </summary>
    /// <returns>Список суперсил конкретного героя.</returns>
    [HttpGet("get-list-for-hero/{heroId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<HeroPowerVM>))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<IEnumerable<HeroPowerVM>>> GetListForHero (int heroId)
        => Ok(await _powerRestVMService.GetByHeroId(heroId));

    /// <summary>
    /// Получить суперсилу.
    /// </summary>
    /// <returns>Суперсила.</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PowerVM))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<PowerVM>> Get (int id)
        => Ok(await _powerRestVMService.Get(id));

    /// <summary>
    /// Создать суперсилу.
    /// </summary>
    /// <returns>Идентификатор созданной суперсилы.</returns>
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult<int>> Create (PowerCreateVM powerCreate)
        => Ok(await _powerRestVMService.Create(powerCreate));

    /// <summary>
    /// Изменить суперсилу.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult> Update (PowerUpdateVM powerUpdate)
    {
        await _powerRestVMService.Update(powerUpdate);
        return NoContent();
    }

    /// <summary>
    /// Удалить суперсилу.
    /// </summary>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(InternalServerErrorVM))]
    public async Task<ActionResult> Delete (int id)
    {
        await _powerRestVMService.Delete(id);
        return NoContent();
    }
}
