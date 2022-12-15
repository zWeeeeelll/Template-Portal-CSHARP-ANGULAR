import { RegistrationsProductsComponent } from './pages/registrations/registrations.products.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { HomeComponent } from './pages/home/home.component';
import { AccessComponent } from './pages/access/access.component';
import { NotfoundComponent } from './pages/notfound/notfound.component';
import { ErrorComponent } from './pages/error/error.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppMainComponent } from './app.main.component';
import { AuthGuard } from './guards/auth-guard';
import { ConfigurationImportsComponent } from './pages/configuration/imports/configuration.imports.component';
import { ConfigurationProductsComponent } from './pages/configuration/products/configuration.produtcs.component';
 
const routes: Routes = [ 
  { path: '', component: AppMainComponent,
    children: [
    { path: '', component: HomeComponent, 
      loadChildren: () => import('../app/pages/home/home.module').then(m => m.HomeModule),
      canActivate: [AuthGuard] 
    },
    { path: 'dashboard/general', component: DashboardComponent, 
    loadChildren: () => import('../app/pages/dashboard/dashboard.module').then(m => m.DashboardModule ),
      canActivate: [AuthGuard] 
    },
    { path: 'registrations/products', component: RegistrationsProductsComponent,
      loadChildren: () => import('./pages/registrations/registrations.products.module').then(m => m.RegistrationsProductsModule )
    },
    { path: 'config/imports', component: ConfigurationImportsComponent,
      loadChildren: () => import('./pages/configuration/imports/configuration.imports.module').then(m => m.ConfigurationImportsModule )
    },
    { path: 'config/products', component: ConfigurationProductsComponent,
      loadChildren: () => import('./pages/configuration/products/configuration.produtcs.module').then(m => m.ConfigurationProductsModule )
    }
  ]},
  { path: 'error', component: ErrorComponent, canActivate: [AuthGuard] },
  { path: 'notfound', component: NotfoundComponent, canActivate: [AuthGuard] },
  { path: 'access', component: AccessComponent, canActivate: [AuthGuard] },
  { path: 'login',
    loadChildren: () => import('../app/pages/login/login.module').then(m => m.LoginModule ) 
  },
  { path: 'register',
    loadChildren: () => import('../app/pages/register/register.module').then(m => m.RegisterModule ) 
  },
  { path: 'changepassword',
  loadChildren: () => import('../app/pages/changepassword/changepassword.module').then(m => m.ChangePasswordModule ) 
  },
  { path: 'landing',
    loadChildren: () => import('../app/pages/landing/landing.module').then(m => m.LandingModule )
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    scrollPositionRestoration: 'enabled', 
    anchorScrolling:'enabled'
  })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
