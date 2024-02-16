import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "@environments/environment";
import { SelectItem } from "@shared/models/forms/select-item";
import { Observable } from "rxjs";

@Injectable({providedIn: 'root'})
  export class SelectItemsApiService {
    private readonly ALL_COUNTRIES = 'api/SelectItems/GetCountryItems';
    private readonly ALL_LANGUAGES = 'api/SelectItems/GetLanguageItems';
    private readonly apiUrl = environment.apiUrl;

    constructor(private http: HttpClient) { }

    getCountries(): Observable<SelectItem[]> {
        return this.http.get<SelectItem[]>(this.apiUrl + this.ALL_COUNTRIES);
    }

    getLanguages(): Observable<SelectItem[]> {
      return this.http.get<SelectItem[]>(this.apiUrl + this.ALL_LANGUAGES);
  }
}