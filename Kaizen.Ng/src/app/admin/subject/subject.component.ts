import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Subject } from '@models/subject';
import { SubjectService } from '@services/subject.service';
import { Observable } from 'rxjs';
import { ConfirmDeleteDialogComponent } from '../confirm-delete-dialog/confirm-delete-dialog.component';

@Component({
  selector: 'app-subject',
  templateUrl: './subject.component.html',
  styleUrls: ['./subject.component.scss']
})
export class SubjectComponent {

  list$ : Observable<Subject[]>;

  displayedColumns : string[] = ['id', 'name', 'actions'];

  constructor(private subjectService : SubjectService,
    private dialog : MatDialog) {
    this.list$ = this.subjectService.list();
  }

  onDelete(id : number) {
    let dialogRef = this.dialog.open(ConfirmDeleteDialogComponent);

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.removeSubject(id);
      }
    });
  }

  removeSubject(id : number) {
    this.subjectService.delete(id).subscribe(() => {
      this.list$ = this.subjectService.list();
    });
  }
}
