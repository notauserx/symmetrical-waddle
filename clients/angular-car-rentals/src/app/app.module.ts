import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MasterComponent } from './layout/master/master.component';
import { TopnavComponent } from './layout/topnav/topnav.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { UserMenuComponent } from './layout/user-menu/user-menu.component';
import { UserLoginComponent } from './core/authentication/user-login/user-login.component';
import { UserRegistrationComponent } from './core/authentication/user-registration/user-registration.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    MasterComponent,
    TopnavComponent,
    SidebarComponent,
    UserMenuComponent,
    UserLoginComponent,
    UserRegistrationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
