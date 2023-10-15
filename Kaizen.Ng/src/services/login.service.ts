import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "src/models/user";

@Injectable({ providedIn : "root"})
export class LoginService {
    constructor(private client : HttpClient) {}


    public login(user : User) : Observable<string> {
        return this.client.post("api/login", user, {responseType : "text"});
    }
    
}