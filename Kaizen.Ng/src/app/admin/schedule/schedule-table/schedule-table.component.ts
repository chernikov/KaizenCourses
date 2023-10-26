import { WeekDay } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DayOfWeek } from '@models/enums/day-of-week.enum';
import { Grade } from '@models/grade';
import { Schedule } from '@models/schedule';
import { TimeSlot } from '@models/time-slot';
import { ScheduleService } from '@services/schedule.service';
import { TimeSlotService } from '@services/time-slot.service';
import { Observable, shareReplay } from 'rxjs';
import { ConfirmDeleteDialogComponent } from '../../confirm-delete-dialog/confirm-delete-dialog.component';
import { SetScheduleDialogComponent } from '../set-schedule-dialog/set-schedule-dialog.component';
import { SelectedSchedule } from '../models/selected-schedule';

@Component({
  selector: 'app-schedule-table',
  templateUrl: './schedule-table.component.html',
  styleUrls: ['./schedule-table.component.scss']
})
export class ScheduleTableComponent {

  @Input('grade') grade : Grade | null = null;

  timeSlots$ : Observable<TimeSlot[]>;
  schedule$ : Observable<Schedule[]>;

  displayedColumns = ["day", "time", "subject", "class-room", "actions"];

  constructor(private timeSlotService : TimeSlotService, 
    private scheduleService : ScheduleService,
    private dialog : MatDialog) {
    this.timeSlots$ = this.timeSlotService.list().pipe(shareReplay(1));
    this.schedule$ = this.scheduleService.list().pipe(shareReplay(1));
  }

  getName(day : DayOfWeek) : string {
    return DayOfWeek[day];
  }

  getSchedule(timeSlot: TimeSlot, schedules : Schedule[] | null, grade : Grade | null) : Schedule | null {
    if (schedules == null) {
      return null;
    }
    if (grade == null) {
      return null;
    }
    const result = schedules.find(p => p.gradeId == grade.id && p.timeSlotId == timeSlot.id);
    return result ?? null;
  }

  onSet(timeslot : TimeSlot) {
    if (this.grade == null) return;

    const selectedSchedule = new SelectedSchedule(0, this.grade, timeslot, null, null);
    let dialogRef = this.dialog.open(SetScheduleDialogComponent,
      {
        data : selectedSchedule
      });

    dialogRef.afterClosed().subscribe(data => {
      if (data) {
        this.schedule$ = this.scheduleService.list().pipe(shareReplay(1));
      }
    });
  }

  onChange(timeslot : TimeSlot, schedule : Schedule) {
    if (this.grade == null) return;

    const selectedSchedule = new SelectedSchedule(schedule.id, this.grade, timeslot, schedule.classRoom, schedule.subject);
    let dialogRef = this.dialog.open(SetScheduleDialogComponent,
      {
        data : selectedSchedule
      });

    dialogRef.afterClosed().subscribe(data => {
        if (data) {
          this.schedule$ = this.scheduleService.list().pipe(shareReplay(1));
        }
     });
  }

  onDelete(schedule : Schedule) {
    let dialogRef = this.dialog.open(ConfirmDeleteDialogComponent);

    dialogRef.afterClosed().subscribe(data => {
      if (data)
      {
        this.scheduleService.delete(schedule.id).subscribe(_ => {
          this.schedule$ = this.scheduleService.list().pipe(shareReplay(1));
        })
      }
    })

  }
}
