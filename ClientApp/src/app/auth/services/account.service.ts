import { Injectable, OnDestroy } from "@angular/core";
import { Router } from "@angular/router";
import { StorageKey } from "@shared/enums/storage-key";
import { ServerResponse } from "@shared/models/server-response";
import { StorageManager } from "@shared/services/storage-manager.service";
import { finalize, Observable, Subject, tap } from "rxjs";
import { AccountApiService } from "../api/account.api.service";
import { Account } from "../models/account";
import { AuthenticateRequest } from "../models/authenticate-request";
import { RegisterRequest } from "../models/register-request";
import { ResetPasswordRequest as ResetPasswordRequest } from "../models/reset-password-request";

@Injectable({providedIn: 'root'})
  export class AccountService implements OnDestroy {
    isLoading: boolean = false;
    hasError: boolean;
    errorText: string;
  
    private refreshTokenTimeout;
    private destroy$ = new Subject<void>();

    constructor(
        private readonly router: Router,
        private readonly api: AccountApiService,
        private readonly storageManager: StorageManager,
    ) { }

    get account(): Account {
        return this.storageManager.getItem(StorageKey.Account) as Account;
    }

    login(email: string, password: string) {
        this.isLoading = true;

        return this.api.login({email, password} as AuthenticateRequest)
            .pipe(tap(account => {
                this.storageManager.saveJwt(account.jwtToken);
                this.storageManager.saveItem(StorageKey.Account, account);
                this.storageManager.saveItem(StorageKey.RefreshToken, account.refreshToken);
                this.startRefreshTokenTimer();
            }),
            finalize(() => this.isLoading = false),
        );
    }

    logout(): void {
        const rt = this.storageManager.getItem(StorageKey.RefreshToken) as string;
        this.api.logout(rt).subscribe();
        this.stopRefreshTokenTimer();
        this.storageManager.removeItem(StorageKey.Account);
        this.storageManager.removeItem(StorageKey.JwtToken);
        this.storageManager.removeItem(StorageKey.RefreshToken);
        this.router.navigate(['/login']);
    }

    refreshToken(): Observable<Account> {
        const rt = this.storageManager.getItem(StorageKey.RefreshToken) as string;
        return this.api.refreshToken(rt)
            .pipe(
                tap((account) => {
                this.storageManager.saveItem(StorageKey.Account, account);
                this.storageManager.saveItem(StorageKey.RefreshToken, account.refreshToken);
                this.startRefreshTokenTimer();
            }));
    }

    register(registerModel: RegisterRequest): Observable<ServerResponse>  {
        this.isLoading = true;
        
        return this.api.register(registerModel)
            .pipe(
                finalize(() => this.isLoading = false)
            );
    }

    verifyEmail(token: string): Observable<ServerResponse> {
        return this.api.verifyEmail(token)      
            .pipe(
                finalize(() => this.isLoading = false)
            );
    }
    
    forgotPassword(email: string): Observable<ServerResponse> {
        this.isLoading = true

        return this.api.forgotPassword(email)
            .pipe(
                finalize(() => this.isLoading = false)
            );
    }
    
    validateResetToken(token: string): Observable<ServerResponse> {
        return this.api.validateResetToken(token);
    }
    
    resetPassword(resetPasswordModel: ResetPasswordRequest) {
        this.isLoading = true;
        
        return this.api.resetPassword(resetPasswordModel)
            .pipe(
                finalize(() => this.isLoading = false)
            );
    }

    onError(text: string): void {
        if (text) {
          this.hasError = true;
          this.errorText = text;
        }
    }

    ngOnDestroy(): void {
        this.stopRefreshTokenTimer();
        this.destroy$.next();
        this.destroy$.complete();
    }

    private startRefreshTokenTimer() {
        const jwtToken = JSON.parse(window.atob(this.account.jwtToken.split('.')[1]));

        const expires = new Date(jwtToken.exp * 1000);
        const timeout = expires.getTime() - Date.now() - (60 * 1000);
        this.refreshTokenTimeout = setTimeout(() => this.refreshToken()
        .subscribe({
            error: () => {
                this.storageManager.removeItem(StorageKey.Account);
                this.storageManager.removeItem(StorageKey.RefreshToken);
            }
        }), timeout);
    }

    private stopRefreshTokenTimer() {
        clearTimeout(this.refreshTokenTimeout);
    }
}