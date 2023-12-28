import { Injectable, OnDestroy, OnInit } from "@angular/core";
import { Gender } from "@shared/enums/gender";
import { ResultCode, ServerResponse } from "@shared/models/server-response";
import { Observable, Subject, tap } from "rxjs";
import { RegisterRequest } from "../models/register-request";
import { AccountService } from "./account.service";

@Injectable({providedIn: 'root'})
  export class RegistrationService implements OnInit, OnDestroy {
    private destroy$ = new Subject<void>();
    private _registerModel: RegisterRequest;

    constructor(private readonly accountService: AccountService) { }

    get registerModel(): RegisterRequest {
      return this._registerModel;
    }
    
    ngOnInit(): void {
      this.resetData();
    }

    applyStepOne(email: string, password: string): void {
      this._registerModel.email = email;
      this._registerModel.password = password;
    }

    applyStepTwo(firstName: string, lastName: string, gender: Gender, countryCode: string): void {
      this._registerModel.firstName = firstName ;
      this._registerModel.lastName = lastName;
      this._registerModel.gender = gender;
      this._registerModel.countryCode = countryCode;
    }

    applyStepThree(languageCodes: string[], targetLanguageCodes: string[]): Observable<ServerResponse> {
      this._registerModel.languageCodes = languageCodes;
      this._registerModel.targetLanguageCodes = targetLanguageCodes;

      return this.accountService.register(this._registerModel).pipe(tap((result: ServerResponse) => {
        if (result.code === ResultCode.Done)
          this.resetData();
      }));
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