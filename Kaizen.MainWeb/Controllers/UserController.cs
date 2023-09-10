using Kaizen.Core;
using Kaizen.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/user")]
public class UserController : Controller
{
    private readonly KaizenDbContext context;

    public UserController(KaizenDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var list = context.Users.ToList();

        return Ok(list);
    }

    [HttpPost]
    public IActionResult Post([FromBody] User user)
    {
        context.Users.Add(user);
        context.SaveChanges();

        return Created("", user);
    }
}
