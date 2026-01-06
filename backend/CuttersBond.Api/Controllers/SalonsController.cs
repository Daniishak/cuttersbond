using Microsoft.AspNetCore.Mvc;
using CuttersBond.Api.Models;

namespace CuttersBond.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SalonsController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Salon>> GetAll()
    {
        var salons = new List<Salon>
        {
            new() { Id = 1, Name = "CuttersBond Örebro", City = "Örebro" },
            new() { Id = 2, Name = "CuttersBond Stockholm", City = "Stockholm" }
        };

        return Ok(salons);
    }
}
