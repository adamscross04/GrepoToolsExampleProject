import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main/main.component';
import { RouterModule } from '@angular/router';
import { MaterialModule } from '../material/material.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { PingPongClientService } from '../ping-pong-client.service';

@NgModule({
  imports: [
    CommonModule,    
    RouterModule.forRoot([
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: MainComponent }
    ]), 
    MaterialModule, 
    FlexLayoutModule
  ],
  declarations: [MainComponent],
  providers: [
    PingPongClientService
  ]
})
export class ViewsModule { }
