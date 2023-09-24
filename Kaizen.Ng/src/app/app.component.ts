import { Component, OnInit } from '@angular/core';
import { User } from 'src/models/user';
import { UserService } from 'src/services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  
  
  users : User[] = []; 
  title = 'kaizen';

  constructor(private userService : UserService) {}

  ngOnInit(): void {

    this.userService.getAll().subscribe(data => {
      this.users = data;
    })
    //this.users.push({id : 1, email : "email@email", "password" : "passwrd"});
  }

  onButtonClick() : void {
    let user = new User();
    user.id = 0;
    user.email = "email@email.com";
    user.password = "hifromfrontend";
    this.userService.add(user).subscribe(data => {
      console.log("User is saved");
    });
    
  }
}
