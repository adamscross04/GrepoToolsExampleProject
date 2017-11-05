import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
https://medium.com/@amcdnl/the-new-http-client-in-angular-4-3-754bd3ff83a8

import { AppComponent } from './app.component';
import { ViewsModule } from './views/views.module';
import { MaterialModule } from './material/material.module';
import { RouterModule } from '@angular/router';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, 
    ViewsModule, 
    MaterialModule, 
    RouterModule.forRoot([]), 
    BrowserAnimationsModule,
    FlexLayoutModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
