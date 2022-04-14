import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { LoginFormComponent } from '../auth/login-form/login-form.component';
import { RegisterFormComponent } from '../auth/register-form/register-form.component';
import { User } from '../models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  currentUser$: Observable<User>;

  constructor(
    private dialog: MatDialog,
    public accountService: AccountService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  openLoginDialog() {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = '25%';
    this.dialog.open(LoginFormComponent, dialogConfig);
  }

  openRegisterDialog() {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = '25%';
    this.dialog.open(RegisterFormComponent, dialogConfig);
  }

  logout() {
    this.accountService.logout();
    this.router.navigate(['/']);
  }
}
