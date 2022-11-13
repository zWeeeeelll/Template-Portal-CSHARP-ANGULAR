import { Component } from '@angular/core';
import { PrimeNGConfig } from 'primeng/api';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  menuMode = 'static';
  storageName = 'template';
  public loading = false;
  public usuarioLogado = false;
  
  constructor(private primengConfig: PrimeNGConfig) { 

  }

  ngOnInit() {
    this.primengConfig.ripple = true;
    document.documentElement.style.fontSize = '12px';
  }

  // showError(message: string) {
  //   this.messageService.add({severity:'error', summary: 'Erro', detail: message});
  // }
}
