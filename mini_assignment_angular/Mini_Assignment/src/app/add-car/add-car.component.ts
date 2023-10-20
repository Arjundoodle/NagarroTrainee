import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { AuthService } from '../auth.service';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-car',
  templateUrl: './add-car.component.html',
  styleUrls: ['./add-car.component.css']
})
export class AddCarComponent implements OnInit {
 
  AddCar: FormGroup;

  constructor(
    private fb: FormBuilder,
    private authservice: AuthService,
    private router:Router
    
  ) {
    this.AddCar = this.fb.group({
      Brand: ['', Validators.required],
      Model: ['', Validators.required],
      RentPerDay: ['', Validators.required]
      
    });
  }

  ngOnInit(): void {}

  NewCar() {
    this.authservice.addcar([
      this.AddCar.value.Brand,
      this.AddCar.value.Model,
      this.AddCar.value.RentPerDay
    ]).subscribe(response => {
      
      return  this.router.navigate(['Admin/carview'])

    });
  }

}
