import { OverlayModule } from '@angular/cdk/overlay';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NativeDateModule } from '@angular/material/core';
import { ToastrModule } from 'ngx-toastr';
import { MaterialModule } from './material.module';

const MODULES = [
  MaterialModule,
  CommonModule,
  FormsModule,
  ReactiveFormsModule,
  ScrollingModule,
  OverlayModule,
  NativeDateModule,
];

@NgModule({
  declarations: [
  ],
  imports: [
    ...MODULES,
    ToastrModule.forRoot({
      timeOut: 10000,
      progressBar: true,
      positionClass: 'genesis-toast-top-right',
    }),
  ],
  exports: [
    ...MODULES,
  ],
})
export class DefaultSetModule { }