import { ClassRoom } from "./class-room";
import { Grade } from "./grade";
import { Subject } from "./subject";
import { TimeSlot } from "./time-slot";

export class Schedule {

    id : number = 0;

    classRoomId : number = 0;
    gradeId : number = 0;
    subjectId : number = 0;
    timeSlotId : number = 0;

    classRoom : ClassRoom | null = null;
    grade : Grade | null = null;
    subject : Subject | null = null;
    timeSlot : TimeSlot | null = null;
}