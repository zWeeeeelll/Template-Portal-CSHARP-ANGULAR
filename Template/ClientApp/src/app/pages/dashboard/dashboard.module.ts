import { MenuModule } from 'primeng/menu';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardComponent } from './dashboard.component';
import { ChartModule } from 'primeng/chart';



@NgModule({
    imports: [
      CommonModule,
      DashboardRoutingModule,
      FormsModule,
      ChartModule,
      MenuModule
    ],
    declarations: [DashboardComponent]
  })
  export class DashboardModule { }