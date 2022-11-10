import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { UserRegistrationResponse } from 'src/app/interfaces/UserRegistrationResponse';
import { UserRegistrationRequest } from 'src/app/interfaces/UserRegistrationRequest';
import { UserLoginRequest } from 'src/app/interfaces/UserLoginRequest';
import {UserLoginResponse } from 'src/app/interfaces/UserLoginResponse'
import { UrlService } from './url.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private authChangeSubject = new Subject<boolean>();
  public authenticationChanged = this.authChangeSubject.asObservable();

  constructor(private http: HttpClient, private urlService: UrlService) { }

  public registerNewUser = (route: string, body: UserRegistrationRequest) => {
    return this.http.post<UserRegistrationResponse>(this.createCompleteUrl(route), body);
  }

  public loginUser = (route:string, body: UserLoginRequest) => {
    return this.http.post<UserLoginResponse>(this.createCompleteUrl(route), body);
  }

  public sendAuthStateChangeNotification = (isAuthenticated: boolean) => {
    console.log(`calling sendAuthStateChangeNotification with ${isAuthenticated}`);
    this.authChangeSubject.next(isAuthenticated);
  }

  public logout = () => {
    localStorage.removeItem("token");
    this.sendAuthStateChangeNotification(false);
  }

  private createCompleteUrl(route:string) {
    return `${this.urlService.baseUrl}/${route}`;
  }
}
