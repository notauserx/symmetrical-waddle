import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/shared/services/authentication.service';

@Component({
  selector: 'app-user-menu',
  templateUrl: './user-menu.component.html',
  styleUrls: ['./user-menu.component.css']
})
export class UserMenuComponent implements OnInit {

  isUserAuthenticated: boolean = false;
  constructor(
    private authService: AuthenticationService
  ) { }

  ngOnInit(): void {
    this.authService.authenticationChanged
      .subscribe(res => {
        this.isUserAuthenticated = res;
      })
  }

  logOut(): void {
    this.authService.logout();
  }
}
