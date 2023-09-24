using AutoMapper;
using Kaizen.Core;
using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/register")]
public class RegisterController  : Controller
{
    private readonly KaizenDbContext context;
    private readonly IMapper mapper;

    public RegisterController(KaizenDbContext context, IMapper mapper) {
        this.context = context;
        this.mapper = mapper;
    }


    [HttpPost]
    public IActionResult Post([FromBody] UserDto user)
    {
        var entity = mapper.Map<User>(user);
        context.Users.Add(entity);
        context.SaveChanges();
        return Created("", entity);
    }
}
