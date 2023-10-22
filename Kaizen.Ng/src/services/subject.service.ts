import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Subject } from "@models/subject";
import { Observable } from "rxjs";

@Injectable({providedIn : "root"})
export class SubjectService {
    private url :string = "/api/subject";

    constructor(private client : HttpClient) {}

    list() : Observable<Subject[]>{
        return this.client.get<Subject[]>(this.url);
    }

    detail(id : number) : Observable<Subject> {
        return this.client.get<Subject>(this.url + "/" + id);
    }

    add(data: Subject) : Observable<Subject> {
        return this.client.post<Subject>(this.url, data);
    }

    save(data:Subject): Observable<Subject> {
        return this.client.put<Subject>(this.url, data);
    }

    delete(id : number) {
        return this.client.delete(this.url + "/" + id);
    }
}