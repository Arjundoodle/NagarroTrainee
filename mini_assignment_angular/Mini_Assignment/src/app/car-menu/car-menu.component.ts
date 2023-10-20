import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../auth.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-car-menu',
  templateUrl: './car-menu.component.html',
  styleUrls: ['./car-menu.component.css']
})
export class CarMenuComponent implements OnInit {
  cars: any[] = [];
  selectedCar: any;
  numberOfDays!: number;
  totalPrice: number = 0;
  acceptAgreement: boolean = false;
 

  constructor(private http: HttpClient, private authservice: AuthService) {}

  ngOnInit(): void {
    this.authservice.carlist().subscribe((data: any[]) => {
      console.log(data);
      this.cars = data;
    });
  }

  calculateTotalPrice() {
    if (this.selectedCar && this.numberOfDays) {
      this.totalPrice = this.selectedCar.rentPerDay * this.numberOfDays;
    } else {
      this.totalPrice = 0;
    }
    return this.totalPrice;
  }

  onAcceptAgreement() {
    this.acceptAgreement = !this.acceptAgreement;
  }

  addnew(){
    
    this.authservice.addagreement([
      this.selectedCar.brand,
      this.selectedCar.model,
      this.selectedCar.rentPerDay,
      this.totalPrice
    ]).subscribe(response => {
      console.log(response)
  })
 }
}
