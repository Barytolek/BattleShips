import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginWindowComponent } from './login-window/login-window.component';
import { RegistrationWindowComponent } from './registration-window/registration-window.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LoginWindowComponent,
    RegistrationWindowComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
