import { OnDestroy } from '@angular/core';
import { Component } from '@angular/core';
import { FormGroup, FormBuilder, AbstractControl, Validators } from '@angular/forms';
import { Gender } from '@shared/enums/gender';
import { SelectItem } from '@shared/models/forms/select-item';
import { SelectItemsService } from '@shared/services/select-items.service';
import { NotificationService } from '@shared/services/notification.service';
import { Subject, takeUntil } from 'rxjs';
import { first } from 'rxjs';
import { AccountService } from '../../services/account.service';
import { RegistrationService } from '../../services/registration.service';
import { BaseAuthenticationComponent } from '../base-authentication.component';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent extends BaseAuthenticationComponent implements OnDestroy {
  form: FormGroup;
  genders: SelectItem[] = 
  [
    {name: 'Man', value: Gender.Man},
    {name: 'Woman', value: Gender.Woman},
  ];

  countries: SelectItem[] = [];
  languageItems: SelectItem[] = [];
  targetLanguageItems: SelectItem[] = [];

  isLinkSent: boolean = false;
  messageText: string = null;

  private destroy$ = new Subject<void>();
  step = 1;

  constructor(
    accountService: AccountService,
    private readonly registrationService: RegistrationService,
    private readonly formBuilder: FormBuilder,
    private readonly notificationService: NotificationService,
    private readonly selectItemsService: SelectItemsService,
  ) { 
    super(accountService);
  }

  get isNextStepDisabled(): boolean {
    if (this.isLoading || !this.form.touched) return true;

    switch (this.step) {
      case 1 : 
        return this.email.invalid || this.firstName.invalid 
          || this.lastName.invalid || this.gender.invalid;
      case 2: 
        return this.country.invalid || this.languages.invalid 
          || this.targetLanguages.invalid; 
      case 3:
        return this.password.invalid || this.confirmPassword.invalid;
      default: 
        return false;
    }
  }

  get email(): AbstractControl { return this.form.controls['email']; }

  get password(): AbstractControl { return this.form.controls['password']; }

  get confirmPassword(): AbstractControl { return this.form.controls['confirmPassword']; }

  get firstName(): AbstractControl { return this.form.controls['firstName']; }

  get lastName(): AbstractControl { return this.form.controls['lastName']; }

  get gender(): AbstractControl { return this.form.controls['gender']; }

  get country(): AbstractControl { return this.form.controls['country']; }

  get languages(): AbstractControl { return this.form.controls['languages']; }

  get targetLanguages(): AbstractControl { return this.form.controls['targetLanguages']; }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
    email: ['', [Validators.required, Validators.email]],
    password: ['', Validators.required],
    confirmPassword: ['', Validators.required],
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    gender: ['', Validators.required],
    country: ['', Validators.required],
    languages: ['', Validators.required],
    targetLanguages: ['', Validators.required]
    });

    this.selectItemsService.getCountriesItemsList()
      .pipe(takeUntil(this.destroy$))
      .subscribe({
        next: (countriesList: SelectItem[]) => {
          this.countries = countriesList;
        },
        error: error => {
          this.notificationService.notifyError(error);
        }
    });

    this.selectItemsService.getLanguageItemsList()
      .pipe(takeUntil(this.destroy$))
      .subscribe({
        next: (languagesList: SelectItem[]) => {
          this.languageItems = languagesList;
          this.targetLanguageItems = [...languagesList];
        },
        error: error => {
          this.notificationService.notifyError(error);
        }
    });

  }

  getLanguageClass(langName: string): string {
    return 'lang-icon lang-icon-' + langName + ' complex-option_icon';
  }

  onChangeLanguage($event): void {
    const value = $event?.value as string[];
    if (value) {
      this.targetLanguageItems = this.targetLanguageItems.filter(
        tL => value.indexOf(tL.value as string) < 0
      );
    }
  }

  onChangeTargetLanguage($event): void {
    const value = $event?.value as string[];
    if (value) {
      this.languageItems = this.languageItems.filter(
        l => value.indexOf(l.value as string) < 0
      );
    }
  }

  onApplyStep(): void {
    if (this.step === 1) {
      this.registrationService.applyStepOne(
        this.email.value, this.firstName.value, this.lastName.value, this.gender.value
      );
      this.step++;
    } else if (this.step === 2) {
      this.registrationService.applyStepTwo(
        this.country.value, this.languages.value, this.targetLanguages.value
      );
      this.step++;
    } else if (this.step === 3) {
      this.registrationService.applyStepThree(this.password.value);
      this.signUp();
    }
  }

  onPreviousStep(): void {
    this.step--;
  }

  private signUp() : void {
    if (this.form.invalid) {
      return;
    }

    this.accountService.register(this.registrationService.registerModel)
      .pipe(first())
      .subscribe({
        next: (result) => {
          this.isLinkSent = true;
          this.messageText = result.message;
          this.registrationService.resetData();
          this.notificationService.notifySuccess('Registration successful');
        },
        error: error => {
          this.notificationService.notifyError(error);
        }
    });
  }
  
  ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }
}
