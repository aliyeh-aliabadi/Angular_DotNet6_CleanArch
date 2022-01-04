import { RouterModule, Routes } from '@angular/router';

import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ServerLogsComponent } from './server-logs/server-logs.component';
import { HomeComponent } from './home/home.component';

import { ServerLogsService } from './server-logs.service';

import { DecimalPipe } from '@angular/common';
import { DatePipe } from '@angular/common';
import { OtherComponent } from './other/other.component';



const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'serverlogs', component: ServerLogsComponent },
 
];

@NgModule({
  declarations: [
    AppComponent,
    ServerLogsComponent,
    HomeComponent,
    OtherComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    ServerLogsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
