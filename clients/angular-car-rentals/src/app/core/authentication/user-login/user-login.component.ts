import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormGroup, FormControl, Validators } from '@angular/forms';

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

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      username: new FormControl<string>("",[Validators.required]),
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

  loginUser = (loginFormValue: LoginRequest) => {
    console.log("hello");
    this.showError = false;
    const login = { ... loginFormValue};

    console.log(login);
  }

}

interface LoginRequest {
  username: string;
  password: string;
}
