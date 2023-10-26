import { Component, OnInit } from '@angular/core';
import { Grade } from '@models/grade';
import { GradeService } from '@services/grade.service';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.scss']
})
export class ScheduleComponent implements OnInit {
    selectedGrade : Grade | null = null;
    grades : Grade[] = [];


    constructor(private gradeService : GradeService) 
    { }
    
    ngOnInit(): void {
      this.gradeService.list().subscribe(data => {
        this.grades = data;
        if (this.grades.length > 0) {
          this.selectedGrade = this.grades[0];
        }
      })
    }


}
