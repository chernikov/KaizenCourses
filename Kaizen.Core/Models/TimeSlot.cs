namespace Kaizen.Core.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }

        public int DayOfWeek { get; set; }

        public TimeOnly Time { get; set; }
    }
}
