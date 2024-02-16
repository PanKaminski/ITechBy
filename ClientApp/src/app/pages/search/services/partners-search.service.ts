import { Injectable } from "@angular/core";
import { RandomPagedModel } from "@shared/models/paged-model";
import { Observable } from "rxjs";
import { PartnersSearchApiService } from "../api/partners-search.api.service";
import { UserCard } from "../models/user-card";

@Injectable({providedIn: 'root'})
  export class PartnersSearchService {
    constructor(private readonly api: PartnersSearchApiService,) { }

    getPossiblePartners(attendedPages: number[]): Observable<RandomPagedModel<UserCard>> {
        return this.api.getPossiblePartners(attendedPages);
    }
}
