import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { TimeSlot } from "@models/time-slot";
import { Observable } from "rxjs";

@Injectable({providedIn : "root"})
export class TimeSlotService {

    private url :string = "/api/time-slot";

    constructor(private client : HttpClient) {}

    list() : Observable<TimeSlot[]>{
        return this.client.get<TimeSlot[]>(this.url);
    }
}