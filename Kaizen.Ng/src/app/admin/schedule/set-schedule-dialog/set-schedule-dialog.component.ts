import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { SelectedSchedule } from '../models/selected-schedule';
import { SubjectService } from '@services/subject.service';
import { ClassRoomService } from '@services/class-room.service';
import { Subject } from '@models/subject';
import { ClassRoom } from '@models/class-room';
import { ScheduleService } from '@services/schedule.service';
import { Schedule } from '@models/schedule';

@Component({
  selector: 'app-set-schedule-dialog',
  templateUrl: './set-schedule-dialog.component.html',
  styleUrls: ['./set-schedule-dialog.component.scss']
})
export class SetScheduleDialogComponent implements OnInit {

  subjects : Subject[] = [];
  classRooms : ClassRoom[] = [];

  constructor(private dialogRef : MatDialogRef<SetScheduleDialogComponent>,
    private subjectService : SubjectService,
    private classRoomService : ClassRoomService,
    private scheduleService : ScheduleService,
    @Inject(MAT_DIALOG_DATA) public selectedSchedule : SelectedSchedule) {

  }

  ngOnInit(): void {
    this.subjectService.list().subscribe(data => {
      this.subjects = data;

      if(this.selectedSchedule.subject) {
        this.selectedSchedule.subject = this.subjects.find(p => p.id == this.selectedSchedule.subject?.id);
      }
    });

    this.classRoomService.list().subscribe(data => {
      this.classRooms = data;

      if(this.selectedSchedule.classRoom) {
        this.selectedSchedule.classRoom = this.classRooms.find(p => p.id == this.selectedSchedule.classRoom?.id);
      }
    });
  }

  Cancel() {
    this.dialogRef.close(false);
  }

  Submit() {
    if(!this.selectedSchedule.classRoom) return;
    if(!this.selectedSchedule.subject) return;

    let schedule = new Schedule();
    
    schedule.gradeId = this.selectedSchedule.grade.id;
    schedule.timeSlotId = this.selectedSchedule.timeSlot.id;
    schedule.classRoomId = this.selectedSchedule.classRoom.id;
    schedule.subjectId = this.selectedSchedule.subject.id;

    if (this.selectedSchedule.scheduleId) {
      schedule.id = this.selectedSchedule.scheduleId;
      this.scheduleService.save(schedule).subscribe(data => {
        this.dialogRef.close(true);
      }); 
    } else {
      this.scheduleService.add(schedule).subscribe(data => {
        this.dialogRef.close(true);
      });
    }
    this.dialogRef.close(true);
  }
}
