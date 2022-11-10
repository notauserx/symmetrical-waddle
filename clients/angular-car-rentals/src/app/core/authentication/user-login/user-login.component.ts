import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { UserLoginRequest } from 'src/app/interfaces/UserLoginRequest';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';
import { UserLoginResponse } from 'src/app/interfaces/UserLoginResponse';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {

  
  private returnUrl!: string;

  loginForm!: FormGroup;
  errorMessage: string = '';
  showError!: boolean;

  constructor(
    private authService: AuthenticationService, 
    private router: Router, 
    private route: ActivatedRoute) 
  
  { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      email: new FormControl<string>("",[Validators.required]),
      password: new FormControl<string>("", [Validators.required])
    });

    this.returnUrl = this.route.snapshot.queryParams["returnUrl"] || '/';
  }

  validateControl = (controlName: string) => {
    return this.loginForm.get(controlName)?.invalid && this.loginForm.get(controlName)?.touched
  }

  hasError = (controlName: string, errorName: string) => {
    return this.loginForm.get(controlName)?.hasError(errorName)
  }

  loginUser = (loginFormValue: UserLoginRequest) => {
    this.showError = false;
    const login = { ... loginFormValue};

    const userLoginRequest: UserLoginRequest = {
      email: login.email,
      password: login.password
    }

    console.log(userLoginRequest);

    this.authService.loginUser('api/auth/login', userLoginRequest)
    .subscribe({
      next: (response: UserLoginResponse) => {
        console.log(response);
        localStorage.setItem("token", response.token);
        this.authService.sendAuthStateChangeNotification(response.isSuccess);
      },
      error: (err: HttpErrorResponse) => {
        this.errorMessage = err.message;
        this.showError = true;
      }
    });    

  }
}

