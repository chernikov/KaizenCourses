﻿using Kaizen.Core.Models;

namespace Kaizen.MainWeb.Dtos;

public class UserDto
{

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;


    public User ToEntity()
    {
        return new User()
        {
            Email = this.Email,
            Password = this.Password
        };
    }
}
