using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;

namespace Kaizen.MainWeb.EntityExtensions;

public static class ClassRoomExtension
{
    public static ClassRoomDto ToDto(this ClassRoom source)
    {
        return new ClassRoomDto()
        {
            Id = source.Id,
            Name = source.Name,
        };
    }
}
