using Kaizen.Core.Enums;

namespace Kaizen.MainWeb.Dtos;

public class TimeSlotDto
{
    public int Id { get; set; }

    public TimeOnly BeginTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public WeekDay DayOfWeek { get; set; }
}
