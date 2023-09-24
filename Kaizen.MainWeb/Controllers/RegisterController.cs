using Kaizen.Core;
using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;
using Kaizen.MainWeb.EntityExtensions;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/register")]
public class RegisterController  : Controller
{
    private readonly KaizenDbContext context;

    public RegisterController(KaizenDbContext context) {
        this.context = context;
    }


    [HttpPost]
    public IActionResult Post([FromBody] UserDto user)
    {
        var isRegistered = context.Users.Any(p => p.Email == user.Email);
        if (isRegistered)
        {
            return BadRequest(error: "User is already registered");
        }
        var entity = user.ToEntity();
        context.Users.Add(entity);
        context.SaveChanges();
        return Created("", entity.ToDto());
    }
}
