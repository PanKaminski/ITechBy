import { NgModule } from '@angular/core';
import { LoadingPanelComponent } from './components/loading-panel/loading-panel.component';
import { DefaultSetModule } from './default.module';
@NgModule({
  declarations: [
    LoadingPanelComponent
  ],
  imports: [
    DefaultSetModule,
  ],
  exports: [
    DefaultSetModule,
  ],
})
export class SharedModule { }