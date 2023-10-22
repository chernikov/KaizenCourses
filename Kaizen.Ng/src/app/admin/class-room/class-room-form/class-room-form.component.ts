import { HttpErrorResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ClassRoom } from '@models/class-room';
import { ClassRoomService } from '@services/class-room.service';

@Component({
  selector: 'app-class-room-form',
  templateUrl: './class-room-form.component.html',
  styleUrls: ['./class-room-form.component.scss']
})
export class ClassRoomFormComponent {
  
  public id : number = 0;
  public form = this.fb.group({
    name : ["", Validators.compose([Validators.required, Validators.maxLength(20)])]
  });

  public errorMessage : string = '';

  constructor(private classRoomService : ClassRoomService, 
    private router : Router, 
    private route: ActivatedRoute, 
    private fb: FormBuilder) {
      this.route.paramMap.subscribe((params) => {
        const paramId = params.get('id');
        if (paramId != null) {
          this.id = parseInt(paramId);
          this.getDetail();
        }
      });
  }

  getDetail() {
    this.classRoomService.detail(this.id).subscribe(data => {
      this.form.controls.name.setValue(data.name);
    })
  }

  
  onSubmit() {
    let classRoom = new ClassRoom();
    classRoom.id = this.id;
    classRoom.name = this.form.controls.name.value ?? "";
    this.errorMessage = "";
    if (this.id) {
      this.classRoomService.save(classRoom).subscribe(_ => {
        this.router.navigateByUrl("/admin/class-room");
      },
      errorResponse => this.errorMessage = errorResponse.error)
    } else {
      this.classRoomService.add(classRoom).subscribe(_ => {
        this.router.navigateByUrl("/admin/class-room");
      }, 
      errorResponse => this.errorMessage = errorResponse.error)
    }
  }
}
