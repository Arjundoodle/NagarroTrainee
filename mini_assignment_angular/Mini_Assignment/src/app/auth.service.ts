import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import {Observable } from 'rxjs'
@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http:HttpClient) { }
  userurl="https://localhost:44353/api/User/CreateUser"
  carurl="https://localhost:44353/api/Car/AddCar"
  getallcars="https://localhost:44353/api/Car/GetCar"
  agreement="https://localhost:44353/api/Agreement/AddAgreement"
  

  registeruser(user:Array<String>):Observable<any>{
    return  this.http.post(this.userurl,{
      FullName:user[0],
      Email:user[1]
    },{
      responseType:'text'
    });
  }
  addcar(car:Array<String>):Observable<any>{
    return  this.http.post(this.carurl,{
      Brand:car[0],
      Model:car[1],
      RentPerDay:car[2]
    },{
      responseType:'text'
    });
  }

  addagreement(agreement:Array<String>):Observable<any>{
    return  this.http.post(this.agreement,{
      Brand:agreement[0],
      Model:agreement[1],
      RentPerDay:agreement[2],
      Total:agreement[3]
      
    },{
      responseType:'text'
    });
  }

  carlist():Observable<any>{
  return this.http.get(this.getallcars)
  }

 deleteCar(carId: number): Observable<any> {
  const url = `https://localhost:44353/api/Car/DeleteCar/${carId}`;
  return this.http.delete(url);
}
}
