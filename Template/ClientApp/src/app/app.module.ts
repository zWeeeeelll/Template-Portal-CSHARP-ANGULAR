import { ErrorService } from './service/database/error.service';
import { SpeedDialModule } from 'primeng/speeddial';
import { Interceptor } from './service/database/config/app.interceptor.module';
import { LoginComponent } from './pages/login/login.component';
import { ErrorComponent } from './pages/error/error.component';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AppFooterComponent } from './app.footer.component';
import { AppMainComponent } from './app.main.component';
import { AppMenuComponent } from './app.menu.component';
import { AppMenuitemComponent } from './app.menuitem.component';
import { AppTopBarComponent } from './app.topbar.component';
import { ConfigService } from './service/app.config.service';
import { MenuService } from './service/app.menu.service';
import { MenuModule } from 'primeng/menu';
import { MenubarModule } from 'primeng/menubar';
import { EmptyComponent } from './pages/empty/empty.component';

import {SplitButtonModule} from 'primeng/splitbutton';
import {RippleModule} from 'primeng/ripple';
import { HomeComponent } from './pages/home/home.component';
import {ToastModule} from 'primeng/toast';
import { MessageService } from 'primeng/api';
import { UserService } from './service/database/user.service';
import { AlertService } from './service/database/alert.service';
import { ModuleService } from './service/database/module.service';
import { NgxLoadingModule } from "ngx-loading";


@NgModule({
  declarations: [
    AppComponent,
    AppMainComponent,
    AppTopBarComponent,
    AppFooterComponent,
    AppMenuComponent,
    AppMenuitemComponent,
    EmptyComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MenuModule,
    MenubarModule,
    Interceptor,
    SplitButtonModule,
    SpeedDialModule,
    RippleModule,
    ToastModule,
    NgxLoadingModule.forRoot({})
    ],
  providers: [{provide: LocationStrategy, useClass: HashLocationStrategy}, MenuService, ConfigService, UserService, MessageService, ErrorService, AlertService, ModuleService, AppMenuComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
