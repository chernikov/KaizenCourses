using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Kaizen.MainWeb.Controllers;

[Authorize]
[Route("api/protected")]
public class ProtectedController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        var sIdClaim = User.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

        var id = int.Parse(sIdClaim.Value);


        var data = $"THIS IS BIG SECRET FOR YOU MY User with ID : {id}";

        return Ok(data);
    }
}
