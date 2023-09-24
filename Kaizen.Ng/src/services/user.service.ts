import {HttpClient} from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { RegisterUser, User } from "src/models/user";

@Injectable({ providedIn : "root"})
export class UserService 
{
    constructor(private client : HttpClient) {}

    getAll() : Observable<User[]> {
        return this.client.get<User[]>("/api/user");
    }

    add(user : User) : Observable<any> {
        return this.client.post("/api/user", user);
    }

    register(user: RegisterUser) : Observable<User> {
        return this.client.post<User>("/api/register", user);
    }
}