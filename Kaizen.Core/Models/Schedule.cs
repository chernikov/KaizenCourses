﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.Core.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; } = null!;

        public int GradeId { get; set; }

        public Grade Grade { get; set; } = null!;

        public int ClassRoomId { get; set; }

        public ClassRoom ClassRoom { get; set; } = null!;

        public int TimeSlotId { get; set; }

        public TimeSlot TimeSlot { get; set; } = null!;
    }
}
