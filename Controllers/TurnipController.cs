using Microsoft.AspNetCore.Mvc;

namespace billy.Controllers;

[ApiController]
[Route("[controller]")]
public class TurnipController : ControllerBase
{

    private readonly ILogger<TurnipController> _logger;

    public TurnipController(ILogger<TurnipController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTurnip")]
    public string Get()
    {
        return "turnip";
    }
}
