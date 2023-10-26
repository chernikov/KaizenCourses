using Kaizen.Core.Models;
using Kaizen.MainWeb.Dtos;

namespace Kaizen.MainWeb.EntityExtensions
{
    public static class TimeSlotExtension
    {
        public static TimeSlotDto ToDto(this TimeSlot source)
        {
            return new TimeSlotDto()
            {
                BeginTime = source.BeginTime,
                EndTime = source.EndTime,
                DayOfWeek = source.DayOfWeek,
                Id = source.Id,
            };
        }
    }
}
