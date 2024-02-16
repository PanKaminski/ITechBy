import { Injectable, OnDestroy, OnInit } from "@angular/core";
import { Gender } from "@shared/enums/gender";
import { Subject } from "rxjs";
import { RegisterRequest } from "../models/register-request";

@Injectable({providedIn: 'root'})
  export class RegistrationService implements OnDestroy {
    private destroy$ = new Subject<void>();
    private _registerModel: RegisterRequest;

    get registerModel(): RegisterRequest {
      return this._registerModel;
    }
    
    constructor() {
      this.resetData();
    }

    applyStepOne(email: string, firstName: string, lastName: string, gender: Gender): void {
      this._registerModel.email = email;
      this._registerModel.firstName = firstName;
      this._registerModel.lastName = lastName;
      this._registerModel.gender = gender;
    }

    applyStepTwo(countryCode: string, languageCodes: string[], targetLanguageCodes: string[]): void {
      this._registerModel.countryCode = countryCode;
      this._registerModel.languageCodes = languageCodes;
      this._registerModel.targetLanguageCodes = targetLanguageCodes;
    }

    applyStepThree(password: string): void {
      this._registerModel.password = password;
    }

    ngOnDestroy(): void {
        this.destroy$.next();
        this.destroy$.complete();
    }

    resetData(): void {
      this._registerModel = {
        email: null,
        password: null,
        lastName: null,
        firstName: null,
        gender: 0,
        countryCode: null,
        languageCodes: [],
        targetLanguageCodes: []
      };
    }
}