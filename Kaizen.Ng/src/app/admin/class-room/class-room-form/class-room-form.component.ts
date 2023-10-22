import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ClassRoom } from '@models/class-room';
import { ClassRoomService } from '@services/class-room.service';

@Component({
  selector: 'app-class-room-form',
  templateUrl: './class-room-form.component.html',
  styleUrls: ['./class-room-form.component.scss']
})
export class ClassRoomFormComponent {
  id : number = 0;
  name : string = '';


  constructor(private classRoomService : ClassRoomService, 
    private router : Router, 
    private route : ActivatedRoute) {
      this.route.paramMap.subscribe(params => {
        this.id = parseInt(params.get('id') ?? "0");
        this.getDetail();
      })
    }

  private getDetail() {
    this.classRoomService.detail(this.id).subscribe(data => {
      this.name = data.name;
    });
  }

  onSubmit() {
    let classRoom = new ClassRoom();
    classRoom.id = this.id;
    classRoom.name = this.name;

    if (classRoom.id) {
      this.classRoomService.save(classRoom).subscribe(_ => {
        this.router.navigateByUrl("/admin/class-room");
      });
    } else {
      this.classRoomService.add(classRoom).subscribe(_ => {
        this.router.navigateByUrl("/admin/class-room");
      });
    }

  }
}
