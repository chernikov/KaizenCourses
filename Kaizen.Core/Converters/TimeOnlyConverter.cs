using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kaizen.Core.Converters;

public class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
{
    public TimeOnlyConverter() :
        base(
            timeOnly => timeOnly.ToTimeSpan(),
            timespan => TimeOnly.FromTimeSpan(timespan))
    { }
}
