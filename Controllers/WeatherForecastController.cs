using DockerDotNetPostgresDemo.Data;
using DockerDotNetPostgresDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerDotNetPostgresDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly AppDbContext _context;

    public WeatherForecastController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get() => Ok(_context.Weathers.ToList());
}
