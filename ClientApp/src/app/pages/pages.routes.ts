import { Routes } from '@angular/router';
import { ScreenComponent } from '@core/components/screen/screen.component';
import { AuthGuard } from '@core/guards/auth.guard';

export const PAGES_ROUTES: Routes = [
    {
      path: '',
      canActivate: [AuthGuard],
      component: ScreenComponent,
      children: [
        {
          path: 'search',
          loadChildren: () => import('./search/search.module').then((m) => m.SearchModule)
        },
      ]
    },
  ];