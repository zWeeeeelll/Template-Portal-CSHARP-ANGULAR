import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MenuModule } from 'primeng/menu';
import { MenubarModule } from 'primeng/menubar';
import { ConfigurationEnviromentComponent } from './configuration.enviroment.component';

const routes: Routes = [
  {
    path: '',
    component: ConfigurationEnviromentComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule,  MenuModule, MenubarModule]
})
export class ConfigurationEnviromentRoutingModule { }
