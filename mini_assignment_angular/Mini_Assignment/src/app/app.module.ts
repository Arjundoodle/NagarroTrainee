import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { ReactiveFormsModule } from '@angular/forms'; 
import { CarMenuComponent } from './car-menu/car-menu.component';
import { OrdersComponent } from './orders/orders.component';
import { AuthService } from './auth.service';
import{FormsModule} from '@angular/forms';
import { AdminComponent } from './admin/admin.component';
import { AddCarComponent } from './add-car/add-car.component';
import { ViewRentalsComponent } from './view-rentals/view-rentals.component';
import { AdmincarviewComponent } from './admincarview/admincarview.component'


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    
    CarMenuComponent,
    OrdersComponent,
    AdminComponent,
    AddCarComponent,
    ViewRentalsComponent,
    AdmincarviewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
