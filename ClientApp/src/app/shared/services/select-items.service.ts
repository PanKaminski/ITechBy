import { Injectable, OnDestroy } from "@angular/core";
import { SelectItemsApiService } from "@shared/api/select-items.api.service";
import { SelectItem } from "@shared/models/forms/select-item";
import { Observable } from "rxjs";
import { Subject } from "rxjs";

@Injectable({providedIn: 'root'})
  export class SelectItemsService implements OnDestroy {
    private destroy$ = new Subject<void>();

    constructor(private api: SelectItemsApiService) { }

    getCountriesItemsList(): Observable<SelectItem[]>{
        return this.api.getCountries();
    }

    getLanguageItemsList(): Observable<SelectItem[]>{
        return this.api.getLanguages();
    }

    ngOnDestroy(): void {
        this.destroy$.next();
        this.destroy$.complete();
    }
}