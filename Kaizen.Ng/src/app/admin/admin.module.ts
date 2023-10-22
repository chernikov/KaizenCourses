import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminComponent } from './admin.component';
import { SideMenuComponent } from './side-menu/side-menu.component';
import { HomeComponent } from './home/home.component';
import { ClassRoomComponent } from './class-room/class-room.component';
import { GradeComponent } from './grade/grade.component';
import { AdminRoutingModule } from './admin.route';
import { MaterialModule } from '../_material/material.module';
import { ClassRoomFormComponent } from './class-room/class-room-form/class-room-form.component';
import { FormsModule } from '@angular/forms';
import { ConfirmDeleteDialogComponent } from './confirm-delete-dialog/confirm-delete-dialog.component';



@NgModule({
  declarations: [
    AdminComponent,
    SideMenuComponent,
    HomeComponent,
    ClassRoomComponent,
    GradeComponent,
    ClassRoomFormComponent,
    ConfirmDeleteDialogComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    AdminRoutingModule,
    MaterialModule


  ]
})
export class AdminModule { }
