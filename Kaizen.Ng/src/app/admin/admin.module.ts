import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminComponent } from './admin.component';
import { ClassRoomComponent } from './class-room/class-room.component';
import { GradeComponent } from './grade/grade.component';
import { SideMenuComponent } from './side-menu/side-menu.component';
import { HomeComponent } from './home/home.component';
import { AdminRouteModule } from './admin.route';
import { MaterialModule } from 'src/_material/material.module';



@NgModule({
  declarations: [
    AdminComponent,
    ClassRoomComponent,
    GradeComponent,
    SideMenuComponent,
    HomeComponent
  ],
  imports: [
    CommonModule,
    AdminRouteModule,
    MaterialModule
  ]
})
export class AdminModule { }
