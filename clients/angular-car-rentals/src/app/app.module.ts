import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MasterComponent } from './layout/master/master.component';
import { TopnavComponent } from './layout/topnav/topnav.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';

@NgModule({
  declarations: [
    AppComponent,
    MasterComponent,
    TopnavComponent,
    SidebarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
