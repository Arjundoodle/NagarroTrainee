import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';

import { CarMenuComponent } from './car-menu/car-menu.component';
import { OrdersComponent } from './orders/orders.component';
import { AdminComponent } from './admin/admin.component';
import { AddCarComponent } from './add-car/add-car.component';
import { ViewRentalsComponent } from './view-rentals/view-rentals.component';
import { AdmincarviewComponent } from './admincarview/admincarview.component';

const routes: Routes = [
 
  { path: 'Login', component: LoginComponent }, 

  { path: 'CarMenu', component: CarMenuComponent }, 
  { path: 'Orders', component: OrdersComponent }, 
  {path:'Admin',component:AdminComponent},
  {path:'Admin/Addcar',component:AddCarComponent},
  {path:'Admin/ViewRentals',component:ViewRentalsComponent},
  {path:'Admin/carview',component:AdmincarviewComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
