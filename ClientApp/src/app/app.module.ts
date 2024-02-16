import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CoreModule } from '@core/core.module';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { JwtModule } from '@auth0/angular-jwt';
import { DefaultSetModule } from '@shared/default.module';
import { tokenGet } from '@shared/services/token-helper';
import { APP_ROUTES } from './app-routes';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    CoreModule,
    DefaultSetModule,
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(APP_ROUTES),
    BrowserAnimationsModule,
    JwtModule.forRoot({
        config: {
          tokenGetter: tokenGet,
          allowedDomains: ["localhost:8181"],
          disallowedRoutes: [],
        }
      })      
],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
