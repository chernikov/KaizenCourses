import { RouterModule, Routes } from '@angular/router';
import { ClassRoomComponent } from './class-room/class-room.component';
import { GradeComponent } from './grade/grade.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
  { path: 'class-room', component: ClassRoomComponent },
  { path: 'grade', component: GradeComponent },
  { path: '', component: HomeComponent },
];


@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class AdminRouteModule {}