using System.ComponentModel.DataAnnotations;

namespace Kaizen.Core.Models;

public class Role
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = null!;

}
