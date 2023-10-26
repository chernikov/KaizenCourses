import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Schedule } from "@models/schedule";
import { Observable } from "rxjs";


@Injectable({providedIn: "root"})
export class ScheduleService {

    url : string  = "/api/schedule";
    constructor(private client : HttpClient) {}


    list() : Observable<Schedule[]> {
        return this.client.get<Schedule[]>(this.url);
    }

    detail(id : number) : Observable<Schedule> {
        return this.client.get<Schedule>(this.url + "/" + id);
    }

    add(data : Schedule) : Observable<Schedule> {
        return this.client.post<Schedule>(this.url, data);
    }

    delete(id : number) : Observable<any> {
        return this.client.delete(this.url + "/" + id);
    }

    save(data : Schedule) : Observable<Schedule> {
        return this.client.put<Schedule>(this.url, data);
    }
}