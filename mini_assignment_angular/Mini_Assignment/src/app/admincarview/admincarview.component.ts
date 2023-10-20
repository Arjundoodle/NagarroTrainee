import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-admincarview',
  templateUrl: './admincarview.component.html',
  styleUrls: ['./admincarview.component.css']
})
export class AdmincarviewComponent implements OnInit {
  cars: any[] = [];
  tag:boolean=false;

  constructor(private http: HttpClient,private authservice:AuthService) {}

  ngOnInit(): void {
    this.authservice.carlist().subscribe(data=>{
      
      console.log(data)
      this.cars = data;
    })
  }

  newdelete(carId:number){
    this.authservice.deleteCar(carId).subscribe(
      (response) => {
        
        console.log('Car deleted successfully:', response);
      },
      (error) => {
        this.tag=true
        console.error('Error deleting car:', error);
      }
    );

  }

}
