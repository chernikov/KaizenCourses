using Kaizen.Core;
using Kaizen.Core.Models;
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
    public IActionResult Post([FromBody] User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
        return Created("", user);
    }
}
