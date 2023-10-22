import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { ClassRoomComponent } from "./class-room/class-room.component";
import { GradeComponent } from "./grade/grade.component";
import { NgModule } from "@angular/core";
import { ClassRoomFormComponent } from "./class-room/class-room-form/class-room-form.component";

const routes: Routes = [
    {path: "class-room", component: ClassRoomComponent},
    {path: "class-room/add", component: ClassRoomFormComponent},
    {path: "class-room/edit/:id", component: ClassRoomFormComponent},
    {path: "grade", component: GradeComponent},
    {path: "", component: HomeComponent},
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class AdminRoutingModule { }