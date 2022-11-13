import { AppComponent } from 'src/app/app.component';
import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit, AfterViewInit, Injectable, OnChanges, SimpleChanges } from '@angular/core';
import { Router, NavigationEnd, NavigationStart } from '@angular/router';
import { Module } from './api/models/module';
import { ErrorService } from './service/database/error.service';
import { ModuleService } from './service/database/module.service';
import { map, Observable, of } from "rxjs";

@Component({
    selector: 'app-menu',
    template: `
        <div class="layout-menu-container">
            <ul class="layout-menu" role="menu" (keydown)="onKeydown($event)">
                
                <li app-menu class="layout-menuitem-category" *ngFor="let item of _modules; let i = index;" role="none">
                    <div class="layout-menuitem-root-text" [attr.aria-label]="[item.label]">{{item.label}}</div>
                    <ul role="menu">
                        <li app-menuitem *ngFor="let child of item.items" [item]="child" [index]="i" role="none"></li>
                    </ul>
                </li>
            </ul>
        </div>
    `,
    changeDetection: ChangeDetectionStrategy.Default
})
export class AppMenuComponent {

    model$ = this.moduleService.getModules().pipe(
        map(data => {
            let model = [];
            if (localStorage.getItem(this.app.storageName)) {
                data.forEach(item => {
                   model.push(
                   {
                        label: '',
                        items:[
                            {label: item.name, icon: '', routerLink: [item.url]}
                        ]
                    }
                );
            })         
            }else{
            var _privateModule = this._modulesDefault;
            if (!_privateModule)
                this.router.navigateByUrl('/landing');
                model = this._modulesDefault;
                this.app.usuarioLogado = false;
            }    
        return model;
        })
    );

    _modules: any[];
    _modulesDefault: Module[] = [
      { name: 'Login', url: '/login', icon: 'login', sequence: 1, id: 1},
      { name: 'Landing', url: '/landing', icon: 'landing', sequence: 2, id: 2},
      { name: 'Register', url: '/register', icon: 'register', sequence: 3, id: 3},
      { name: 'ChangePassword', url: '/changepassword', icon: 'register', sequence: 3, id: 3},
      { name: 'Error', url: '/error', icon: 'register', sequence: 3, id: 3},
      { name: 'Notfound', url: '/notfound', icon: 'register', sequence: 3, id: 3},
      { name: 'Access', url: '/access', icon: 'register', sequence: 3, id: 3},
    ];

    constructor(private moduleService: ModuleService, private router: Router,private errorService: ErrorService, private app: AppComponent,private cdr: ChangeDetectorRef) { 
        router.events.subscribe(event => {
            if (event instanceof NavigationEnd){
                if (localStorage.getItem(this.app.storageName)) {
                    this.moduleService.getModules().pipe(
                        map(data => {
                            let model = [];
                                data.forEach(item => {
                                   model.push(
                                   {
                                        label: '',
                                        items:[
                                            {label: item.name, icon: '', routerLink: [item.url]}
                                        ]
                                    }
                                );
                            })         
                            return model;
                           })
                    ).subscribe(data => {
                      this._modules = data;
                      this.app.usuarioLogado = true;
                    }, err => {
                      this.router.navigateByUrl("/login");
                      this.errorService.validateError(err);
                      this._modules = this._modulesDefault;
                      this.app.usuarioLogado = false;
                    });
                  }else{
                    var _privateModule = this._modulesDefault.find(mod => mod.url==event.url);
                    this.app.usuarioLogado = false;
                    if (!_privateModule)
                    this.router.navigateByUrl('/landing');
                    this._modules = this._modulesDefault;
                  }
              } 
           }
        );
        
    } 

    getModules() {
        this.router.events.subscribe(event => {
            if (event instanceof NavigationEnd){
              if (localStorage.getItem(this.app.storageName)) {
                this.moduleService.getModules().pipe(
                    map(data => {
                        let model = [];
                            data.forEach(item => {
                               model.push(
                               {
                                    label: '',
                                    items:[
                                        {label: item.name, icon: '', routerLink: [item.url]}
                                    ]
                                }
                            );
                        })         
                        return model;
                       })
                ).subscribe(data => {
                  this._modules = data;
                  this.app.usuarioLogado = true;
                }, err => {
                  this.router.navigateByUrl("/login");
                  this.errorService.validateError(err);
                  this._modules = this._modulesDefault;
                  this.app.usuarioLogado = false;
                });
              }else{
                var _privateModule = this._modulesDefault.find(mod => mod.url==event.url);
                this.app.usuarioLogado = false;
                if (!_privateModule)
                this.router.navigateByUrl('/landing');
                this._modules = this._modulesDefault;
              }
           }
            
        });
      } 

    onKeydown(event: KeyboardEvent) {
        const nodeElement = (<HTMLDivElement> event.target);
        if (event.code === 'Enter' || event.code === 'Space') {
            nodeElement.click();
            event.preventDefault();
        }
    }
}
