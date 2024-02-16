import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "@environments/environment";
import { RandomPagedModel } from "@shared/models/paged-model";
import { Observable } from "rxjs";
import { UserCard } from "../models/user-card";

@Injectable({providedIn: 'root'})
  export class PartnersSearchApiService {
    private readonly FIND_LANGUAGE_PAERTNERS = 'api/LanguagePartners/GetPossiblePartners';

    private readonly apiUrl = environment.apiUrl;

    constructor(private http: HttpClient) { }

    getPossiblePartners(attendedPages: number[]): Observable<RandomPagedModel<UserCard>> {
        return this.http.post<RandomPagedModel<UserCard>>(
            this.apiUrl + this.FIND_LANGUAGE_PAERTNERS, { attendedPages }
        );
    }
}