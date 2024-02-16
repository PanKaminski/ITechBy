import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from '@shared/shared.module';
import { PartnersSearchComponent } from './components/partners-search/partners-search.component';
import { SEARCH_ROUTES } from './search.routes';
import { UserCardItemComponent } from './components/user-card-item/user-card-item.component';

@NgModule({
  declarations: [
    PartnersSearchComponent,
    UserCardItemComponent
  ],
  imports: [
    SharedModule,
    RouterModule.forChild(SEARCH_ROUTES),
  ]
})
export class SearchModule { }
