﻿using Kaizen.Core;
using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Kaizen.MainWeb.Controllers;

[Route("api/login")]
public class LoginController : Controller
{
    private readonly KaizenDbContext context;
    private readonly IConfiguration configuration;

    public LoginController(KaizenDbContext context, IConfiguration configuration)
    {
        this.context = context;
        this.configuration = configuration;
    }

    [HttpPost]
    public IActionResult Post([FromBody] UserDto user)
    {
        var entity = context.Users.FirstOrDefault(p => p.Email == user.Email 
        && p.Password == user.Password);

        if (entity == null) {

            return BadRequest("Username and/or password are incorrect");
        }

        var token = CreateToken(entity);

        return Ok(token);
    }

    private string CreateToken(User entity)
    {
        var tokenHandler = new JwtSecurityTokenHandler();

        var jwtSecret = configuration["JwtSecret"]!;
        var key = Encoding.ASCII.GetBytes(jwtSecret);

        var userRoles = context.UserRoles
                    .Include(p => p.Role)
                    .Where(p => p.UserId == entity.Id)
                    .ToList();

        var roles = userRoles.Select(p => p.Role).ToList();

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Sid, entity.Id.ToString()),
            new Claim(ClaimTypes.Email, entity.Email)
        };

        foreach(var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role.Name));
        }

        var identity = new ClaimsIdentity(claims);

        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = identity,
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}
