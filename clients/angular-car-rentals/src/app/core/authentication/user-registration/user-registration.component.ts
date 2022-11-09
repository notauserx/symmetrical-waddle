import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpErrorResponse} from '@angular/common/http';

@Component({
  selector: 'app-user-registration',
  templateUrl: './user-registration.component.html',
  styleUrls: ['./user-registration.component.css']
})
export class UserRegistrationComponent implements OnInit {

  registrationForm!: FormGroup;
  showError!: boolean;
  constructor() { }

  ngOnInit(): void {
    this.registrationForm = new FormGroup({
      firstName: new FormControl(''),
      lastName: new FormControl(''),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required]),
      confirm: new FormControl('')
    });
  }

  validateControl = (controlName: string) => {
    return this.registrationForm.get(controlName)?.invalid && this.registrationForm.get(controlName)?.touched
  }

  hasError = (controlName: string, errorName: string) => {
    return this.registrationForm.get(controlName)?.hasError(errorName)
  }

  public registerUser = (registerFormValue: any) => {
    this.showError = false;
    const formValues = { ...registerFormValue };

    const user: UserRegistrationRequest = {
      firstName: formValues.firstName,
      lastName: formValues.lastName,
      email: formValues.email,
      password: formValues.password,
    };

    /*
    this.authService.registerUser("api/accounts/registration", user)
    .subscribe({
      next: (_) => this.router.navigate(["/authentication/login"]),
      error: (err: HttpErrorResponse) => {
        this.errorMessage = err.message;
        this.showError = true;
      }
    })

    */
  }
}

interface UserRegistrationRequest {
  firstName: string;
  lastName: string;
  email: string;
  password: string;
}