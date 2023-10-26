import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminRoutingModule } from './admin.route';
import { RouterModule } from '@angular/router';
import { MaterialModule } from '../_material/material.module';

import { ConfirmDeleteDialogComponent } from './confirm-delete-dialog/confirm-delete-dialog.component';
import { HomeComponent } from './home/home.component';
import { ClassRoomComponent } from './class-room/class-room.component';
import { GradeComponent } from './grade/grade.component';
import { AdminComponent } from './admin.component';
import { SideMenuComponent } from './side-menu/side-menu.component';
import { ClassRoomFormComponent } from './class-room/class-room-form/class-room-form.component';
import { GradeFormComponent } from './grade/grade-form/grade-form.component';

import { SubjectComponent } from './subject/subject.component';
import { SubjectFormComponent } from './subject/subject-form/subject-form.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { ScheduleTableComponent } from './schedule/schedule-table/schedule-table.component';
import { SetScheduleDialogComponent } from './schedule/set-schedule-dialog/set-schedule-dialog.component';

@NgModule({
  declarations: [
    HomeComponent,
    AdminComponent,
    SideMenuComponent,
    ConfirmDeleteDialogComponent,

    ClassRoomComponent,
    GradeComponent,
    SubjectComponent,
    ClassRoomFormComponent,
    GradeFormComponent,
    SubjectFormComponent,
    ScheduleComponent,
    ScheduleTableComponent,
    SetScheduleDialogComponent,
    
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    AdminRoutingModule,
    CommonModule,
    RouterModule,
    MaterialModule
  ]
})
export class AdminModule { }
