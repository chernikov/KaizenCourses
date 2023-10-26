import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { ClassRoomComponent } from "./class-room/class-room.component";
import { GradeComponent } from "./grade/grade.component";
import { NgModule } from "@angular/core";
import { ClassRoomFormComponent } from "./class-room/class-room-form/class-room-form.component";
import { GradeFormComponent } from "./grade/grade-form/grade-form.component";
import { SubjectFormComponent } from "./subject/subject-form/subject-form.component";
import { SubjectComponent } from "./subject/subject.component";
import { ScheduleComponent } from "./schedule/schedule.component";

const routes: Routes = [
    { path: 'class-room/add', component: ClassRoomFormComponent },
  { path: 'class-room/edit/:id', component: ClassRoomFormComponent },
  { path: 'class-room', component: ClassRoomComponent },
  { path: 'grade/add', component: GradeFormComponent },
  { path: 'grade/edit/:id', component: GradeFormComponent },
  { path: 'grade', component: GradeComponent },
  { path: 'subject/add', component: SubjectFormComponent },
  { path: 'subject/edit/:id', component: SubjectFormComponent },
  { path: 'subject', component: SubjectComponent },
  { path: 'schedule', component: ScheduleComponent },
  { path: '', component: HomeComponent },
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class AdminRoutingModule { }