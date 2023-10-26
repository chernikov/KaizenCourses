import { DayOfWeek } from "./enums/day-of-week.enum";

export class TimeSlot {
    id : number = 0;
    beginTime : string = '';
    endTime : string = '';
    dayOfWeek : DayOfWeek = DayOfWeek.None;
}