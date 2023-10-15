import { Component } from '@angular/core';
import { Grade } from '@models/grade';
import { GradeService } from '@services/grade.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-grade',
  templateUrl: './grade.component.html',
  styleUrls: ['./grade.component.scss']
})
export class GradeComponent  {
 
  list$ : Observable<Grade[]>;

  displayedColumns : string[] = ["id", "name", "actions"];

  constructor(private gradeService : GradeService) {
    this.list$ = this.gradeService.list();
  } 

}
