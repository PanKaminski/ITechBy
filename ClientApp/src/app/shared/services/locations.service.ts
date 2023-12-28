import { Injectable, OnDestroy } from "@angular/core";
import { LocationsApiService } from "@shared/api/locations.api.service";
import { Country } from "@shared/models/country";
import { SelectItem } from "@shared/models/forms/select-item";
import { map, Observable } from "rxjs";
import { Subject } from "rxjs";

@Injectable({providedIn: 'root'})
  export class LocationsService implements OnDestroy {
    private destroy$ = new Subject<void>();

    constructor(private api: LocationsApiService) { }

    getCountriesItemsList(): Observable<SelectItem[]>{
        return this.api.getCountryNames().pipe(
            map((countries: Country[]) => {
                let items = countries.map(c => {
                    return { name: c.name.common, value: c.cca3 }
                });
                return items;
            }),
        );
    }

    ngOnDestroy(): void {
        this.destroy$.next();
        this.destroy$.complete();
    }
}