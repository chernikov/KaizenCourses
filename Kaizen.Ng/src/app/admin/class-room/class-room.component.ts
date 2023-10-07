import { Component, OnInit } from '@angular/core';
import { ClassRoom } from '@models/class-room';
import { ClassRoomService } from '@services/class-room.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-class-room',
  templateUrl: './class-room.component.html',
  styleUrls: ['./class-room.component.scss']
})
export class ClassRoomComponent {

  columns : string[] = ["id", "name", "actions"]
  list$ : Observable<ClassRoom[]>;

  constructor(private classRoomService : ClassRoomService) {
    this.list$ = this.classRoomService.getAll();
  }
}
