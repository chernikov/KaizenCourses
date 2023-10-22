import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ClassRoom } from "@models/class-room";


@Injectable({providedIn: "root"})
export class ClassRoomService {

    url : string  = "/api/class-room";
    constructor(private client : HttpClient) {}


    list() : Observable<ClassRoom[]> {
        return this.client.get<ClassRoom[]>(this.url);
    }

    detail(id : number) : Observable<ClassRoom> {
        return this.client.get<ClassRoom>(this.url + "/" + id);
    }

    add(data : ClassRoom) : Observable<ClassRoom> {
        return this.client.post<ClassRoom>(this.url, data);
    }

    delete(id : number) : Observable<any> {
        return this.client.delete(this.url + "/" + id);
    }

    save(data : ClassRoom) : Observable<ClassRoom> {
        return this.client.put<ClassRoom>(this.url, data);
    }


}