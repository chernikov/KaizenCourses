using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;

namespace Kaizen.MainWeb.EntityExtensions;

public static class SubjectExtension
{
    public static SubjectDto ToDto(this Subject subject)
    {
        return new SubjectDto()
        {
            Id = subject.Id,
            Name = subject.Name
        };
    }
}
