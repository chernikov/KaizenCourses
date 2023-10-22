using Kaizen.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.Core.Models;

public class TimeSlot
{
    public int Id { get; set; }

    public TimeOnly BeginTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public WeekDay DayOfWeek { get; set; } 

}
