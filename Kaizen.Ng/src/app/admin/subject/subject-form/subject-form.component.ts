import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Subject } from '@models/subject';
import { SubjectService } from '@services/subject.service';

@Component({
  selector: 'app-subject-form',
  templateUrl: './subject-form.component.html',
  styleUrls: ['./subject-form.component.scss']
})
export class SubjectFormComponent {

  public id : number = 0;
  public form = this.fb.group({
    name : ["", Validators.compose([Validators.required, Validators.maxLength(20)])]
  });
  public errorMessage : string = '';

  constructor(private subjectService : SubjectService, 
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
    this.subjectService.detail(this.id).subscribe(data => {
      this.form.controls.name.setValue(data.name);
    })
  }

  onSubmit() {
    let subject = new Subject();
    subject.id = this.id;
    subject.name = this.form.controls.name.value ?? "";
    this.errorMessage = "";
    
    if (this.id) {
      this.subjectService.save(subject).subscribe(_ => {
        this.router.navigateByUrl("/admin/subject");
      }, 
      errorResponse => this.errorMessage = errorResponse.error)
    } else {
      this.subjectService.add(subject).subscribe(_ => {
        this.router.navigateByUrl("/admin/subject");
      },
      errorResponse => this.errorMessage = errorResponse.error)
    }
  }
}
