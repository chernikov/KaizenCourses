using Kaizen.Core.Models;

namespace Kaizen.MainWeb.Dtos;

public class ScheduleDto
{
    public int Id { get; set; }

    public int ClassRoomId { get; set; }

    public ClassRoomDto ClassRoom { get; set; } = null!;

    public int SubjectId { get; set; }

    public SubjectDto Subject { get; set; } = null!;

    public int GradeId { get; set; }

    public GradeDto Grade { get; set; } = null!;

    public int TimeSlotId { get; set; }

    public TimeSlotDto TimeSlot { get; set; } = null!;


    public Schedule ToEntity()
    {
        return new Schedule
        {
            Id = this.Id,
            ClassRoomId = this.ClassRoomId,
            GradeId = this.GradeId,
            SubjectId = this.SubjectId,
            TimeSlotId = this.TimeSlotId
        };
    }
}
