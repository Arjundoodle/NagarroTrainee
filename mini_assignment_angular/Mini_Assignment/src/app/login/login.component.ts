import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { AuthService } from '../auth.service';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router'; // Import Router

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  myuser: FormGroup;

  constructor(
    private fb: FormBuilder,
    private authservice: AuthService,
    private router: Router // Inject Router
  ) {
    this.myuser = this.fb.group({
      FullName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
    });
  }

  ngOnInit(): void {}

  RegisterUser() {
    this.authservice.registeruser([
      this.myuser.value.FullName,
      this.myuser.value.email
    ]).subscribe(response => {
      if (this.myuser.value.email === 'arjun.kapoor@nagarro.com') {
       
        this.router.navigate(['/Admin']); 
      } else {
        this.router.navigate(['/CarMenu']);
      }
    });
  }
}
