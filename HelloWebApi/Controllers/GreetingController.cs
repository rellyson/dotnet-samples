using Microsoft.AspNetCore.Mvc;
using HelloWebApi.Services.Interfaces;

namespace HelloWebApi.Controllers;

[ApiController]
[Route("/api/greetings")]
public class GreetingController(IGreetingService GreetingService) : ControllerBase
{
    private readonly IGreetingService _greetingService = GreetingService;

    [HttpGet]
    public ActionResult Hello([FromQuery] string? name)
    {
        string greeting = string.IsNullOrEmpty(name)
        ? _greetingService.Hello()
        : _greetingService.Hello(name);

        return Ok(greeting);
    }
}
