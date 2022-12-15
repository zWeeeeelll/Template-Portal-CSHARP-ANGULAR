import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MenuModule } from 'primeng/menu';
import { MenubarModule } from 'primeng/menubar';
import { ConfigurationImportsComponent } from './configuration.imports.component';

const routes: Routes = [
  {
    path: '',
    component: ConfigurationImportsComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule,  MenuModule, MenubarModule]
})
export class ConfigurationImportsRoutingModule { }
