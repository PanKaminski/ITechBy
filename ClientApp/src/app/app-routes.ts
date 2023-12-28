import { Routes } from '@angular/router';
import { PageNotFoundComponent } from '@core/components/page-not-found/page-not-found.component';
import { RouterComponent } from '@core/components/router.component';
import { AuthGuard } from '@core/guards/auth.guard';

export const APP_ROUTES: Routes = [
    {
        path: '',
        loadChildren: () => import('./auth/auth.module').then((m) => m.AuthenticationModule)
    },   
    {
        path: '**',
        redirectTo: '404'
    },
    //Wild Card Route for 404 request
    {
        path: '404',
        pathMatch: 'full',
        component: PageNotFoundComponent
    },
]