using Kaizen.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Kaizen.MainWeb.Dtos;

public class SubjectDto
{
    public int Id { get; set; }

    [MaxLength(20)]
    [Required]
    public string Name { get; set; } = null!;

    public Subject ToEntity()
    {
        return new Subject()
        {
            Id = this.Id,
            Name = this.Name
        };
    }
}
