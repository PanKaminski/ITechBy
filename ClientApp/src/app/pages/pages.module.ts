import { NgModule } from '@angular/core';
import { PAGES_ROUTES } from './pages.routes';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(PAGES_ROUTES)
  ]
})
export class PagesModule { }
