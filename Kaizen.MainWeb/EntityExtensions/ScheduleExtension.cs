using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;

namespace Kaizen.MainWeb.EntityExtensions;

public static class ScheduleExtension
{
    public static ScheduleDto ToDto(this Schedule source)
    {
        return new ScheduleDto()
        {
            Id = source.Id,
            ClassRoomId = source.ClassRoomId,
            ClassRoom = source.ClassRoom.ToDto(),
            GradeId = source.GradeId,
            Grade = source.Grade.ToDto(),
            SubjectId  = source.SubjectId,
            Subject = source.Subject.ToDto(),
            TimeSlotId = source.TimeSlotId,
            TimeSlot = source.TimeSlot.ToDto()
        };
    }
}
