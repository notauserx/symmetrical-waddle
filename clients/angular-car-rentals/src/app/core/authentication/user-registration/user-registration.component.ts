import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpErrorResponse} from '@angular/common/http';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';
import { Router } from '@angular/router';
import { UserRegistrationRequest } from 'src/app/interfaces/UserRegistrationRequest';

@Component({
  selector: 'app-user-registration',
  templateUrl: './user-registration.component.html',
  styleUrls: ['./user-registration.component.css']
})
export class UserRegistrationComponent implements OnInit {

  registrationForm!: FormGroup;
  errorMessage!: string;
  showError!: boolean;
  constructor(private authService: AuthenticationService, private router: Router) { }

  ngOnInit(): void {
    this.registrationForm = new FormGroup({
      firstname: new FormControl(''),
      lastname: new FormControl(''),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required]),
      confirmPassword: new FormControl('')
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

    
    this.authService.registerNewUser("api/accounts/registration", user)
    .subscribe({
      next: (_) => this.router.navigate(["/authentication/login"]),
      error: (err: HttpErrorResponse) => {
        this.errorMessage = err.message;
        this.showError = true;
      }
    });

    
  }
}

