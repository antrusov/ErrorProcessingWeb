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

    //GetPlainById
    //GetDetailedById
    //Update
    //Delete
    //Create

    //[HttpGet(Name = "GetWeatherForecast")]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //    {
    //        Date = DateTime.Now.AddDays(index),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //}
}
