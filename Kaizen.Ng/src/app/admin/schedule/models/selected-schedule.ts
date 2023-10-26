import { ClassRoom } from "@models/class-room";
import { Grade } from "@models/grade";
import { Subject } from "@models/subject";
import { TimeSlot } from "@models/time-slot";

export class SelectedSchedule {
    constructor(public scheduleId : number | null | undefined, 
        public grade : Grade, 
        public timeSlot : TimeSlot, 
        public classRoom : ClassRoom | null | undefined, 
        public subject : Subject | null | undefined, 
        ) { }
}