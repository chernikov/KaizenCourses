import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ClassRoom } from "@models/class-room";

@Injectable({providedIn : "root"})
export class ClassRoomService {

    private url = "api/class-room";
    constructor(private client : HttpClient) {}


    getAll() : Observable<ClassRoom[]> {
        return this.client.get<ClassRoom[]>(this.url);
    }

    get(id : number) : Observable<ClassRoom> {
        return this.client.get<ClassRoom>(this.url + "/" + id);
    }

    add(data : ClassRoom) :Observable<ClassRoom> {
        return this.client.post<ClassRoom>(this.url, data);
    }

    save(data : ClassRoom) :Observable<ClassRoom> {
        return this.client.put<ClassRoom>(this.url, data);
    }

    delete(id : number) {
        return this.client.delete(this.url + "/" + id);
    }
}