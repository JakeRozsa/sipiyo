import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css'],
})
export class LoginFormComponent implements OnInit {
  loginForm: FormGroup;

  constructor(
    private accountService: AccountService,
    public dialogRef: MatDialogRef<LoginFormComponent>
  ) {}

  ngOnInit(): void {
    this.initializeForm();
  }

  initializeForm() {
    this.loginForm = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [
        Validators.required,
        Validators.minLength(4),
        Validators.maxLength(12),
      ]),
    });
  }
  login() {
    this.accountService.login(this.loginForm.value).subscribe(
      (response) => {
        console.log(response);
        this.onClose();
      },
      (error) => {
        console.log(error);
      }
    );
  }

  onClose() {
    this.dialogRef.close();
  }
}
