import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Country } from "@shared/models/country";
import { Observable } from "rxjs";

@Injectable({providedIn: 'root'})
  export class LocationsApiService {
    private readonly ALL_COUNTRIES = 'https://restcountries.com/v3.1/all?fields=name,cca3';

    constructor(private http: HttpClient) { }

    getCountryNames(): Observable<Country[]> {
        return this.http.get<Country[]>(this.ALL_COUNTRIES);
    }
}