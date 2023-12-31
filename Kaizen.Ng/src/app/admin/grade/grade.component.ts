import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Grade } from '@models/grade';
import { GradeService } from '@services/grade.service';
import { Observable } from 'rxjs';
import { ConfirmDeleteDialogComponent } from '../confirm-delete-dialog/confirm-delete-dialog.component';

@Component({
  selector: 'app-grade',
  templateUrl: './grade.component.html',
  styleUrls: ['./grade.component.scss']
})
export class GradeComponent {

  list$ : Observable<Grade[]>;

  displayedColumns : string[] = ['id', 'name', 'actions'];

  constructor(private gradeService : GradeService,
    private dialog : MatDialog) {
    this.list$ = this.gradeService.list();
  }

  onDelete(id : number) {
    let dialogRef = this.dialog.open(ConfirmDeleteDialogComponent);

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.removeGrade(id);
      }
    });
  }

  removeGrade(id : number) {
    this.gradeService.delete(id).subscribe(() => {
      this.list$ = this.gradeService.list();
    });
  }
}
