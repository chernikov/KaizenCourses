using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.Core.Models;

public class TeacherOfSubject
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public int SubjectId { get; set; }

    public Subject Subject { get; set; } = null!;

}
