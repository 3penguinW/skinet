import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import {CheckoutComponent} from './checkout.component';
import { from } from 'rxjs';

const routes: Routes = [
  {path: '', component: CheckoutComponent}
];
@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)

  ],
  exports: [RouterModule]
})
export class CheckoutRoutingModule { }
