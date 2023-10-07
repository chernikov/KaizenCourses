using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;

namespace Kaizen.MainWeb.EntityExtensions;

public static class GradeExtension
{

    public static GradeDto ToDto(this Grade source)
    {
        return new GradeDto()
        {
            Id = source.Id,
            Name = source.Name
        };
    }

}
