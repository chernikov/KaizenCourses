import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Grade } from "@models/grade";
import { Observable } from "rxjs";

@Injectable({providedIn : "root"})
export class GradeService {

    private url :string = "/api/grade";

    constructor(private client : HttpClient) {}

    list() : Observable<Grade[]>{
        return this.client.get<Grade[]>(this.url);
    }

    detail(id : number) : Observable<Grade> {
        return this.client.get<Grade>(this.url + "/" + id);
    }

    add(data: Grade) : Observable<Grade> {
        return this.client.post<Grade>(this.url, data);
    }

    save(data:Grade): Observable<Grade> {
        return this.client.put<Grade>(this.url, data);
    }

    delete(id : number) {
        return this.client.delete(this.url + "/" + id);
    }
}