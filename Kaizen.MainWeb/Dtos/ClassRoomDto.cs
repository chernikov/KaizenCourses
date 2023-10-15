﻿using Kaizen.Core.Models;

namespace Kaizen.MainWeb.Dtos;

public class ClassRoomDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ClassRoom ToEntity()
    {
        return new ClassRoom()
        {
            Id = Id,
            Name = Name,
        };
    }
}
