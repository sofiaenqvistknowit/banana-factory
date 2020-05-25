import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ToolbarComponent } from './toolbar/toolbar.component';
import { ContextComponent } from './context/context.component';
import { LogginPageComponent } from './loggin-page/loggin-page.component';


@NgModule({
  declarations: [
    AppComponent,
    ToolbarComponent,
    ContextComponent,
    LogginPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
