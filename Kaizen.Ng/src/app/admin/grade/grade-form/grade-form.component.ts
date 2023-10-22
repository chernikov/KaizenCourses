import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Grade } from '@models/grade';
import { GradeService } from '@services/grade.service';

@Component({
  selector: 'app-grade-form',
  templateUrl: './grade-form.component.html',
  styleUrls: ['./grade-form.component.scss']
})
export class GradeFormComponent {
  public id : number = 0;
  public form = this.fb.group({
    name : ["", Validators.compose([Validators.required, Validators.maxLength(20)])]
  });
  public errorMessage : string = '';
  
  constructor(private gradeService : GradeService, 
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
    this.gradeService.detail(this.id).subscribe(data => {
      this.form.controls.name.setValue(data.name);
    })
  }

  onSubmit() {
    let grade = new Grade();
    grade.id = this.id;
    grade.name = this.form.controls.name.value ?? "";
    this.errorMessage = "";

    if (this.id) {
      this.gradeService.save(grade).subscribe(_ => {
        this.router.navigateByUrl("/admin/grade");
      }, 
      errorResponse => this.errorMessage = errorResponse.error)
    } else {
      this.gradeService.add(grade).subscribe(_ => {
        this.router.navigateByUrl("/admin/grade");
      }, 
      errorResponse => this.errorMessage = errorResponse.error)
    }
  }
}
