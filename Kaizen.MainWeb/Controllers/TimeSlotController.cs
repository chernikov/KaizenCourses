using Kaizen.Core;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/time-slot")]
public class TimeSlotController : Controller
{
    private readonly KaizenDbContext context;

    public TimeSlotController(KaizenDbContext context)
    {
        this.context = context;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        var list = context.TimeSlots.ToList();

        var result = list.Select(p =>p.ToDto());
        return Ok(result);


    }
}
