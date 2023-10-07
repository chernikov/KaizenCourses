using Kaizen.Core.Models;

namespace Kaizen.MainWeb.Dtos;

public class GradeDto
{

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public Grade ToEntity()
    {

        return new Grade()
        {
            Id = Id,
            Name = Name
        };
    }


}
