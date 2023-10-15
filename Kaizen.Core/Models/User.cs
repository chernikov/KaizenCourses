﻿using System.ComponentModel.DataAnnotations;

namespace Kaizen.Core.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;


    public List<UserRole> UserRoles { get; set; } = null!;

    public int? GradeId { get; set; }

    public Grade? Grade { get; set; }

}
