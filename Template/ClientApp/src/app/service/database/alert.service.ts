import { Injectable } from "@angular/core";
import { MessageService } from "primeng/api";

@Injectable()
export class AlertService {

  constructor(private messageService: MessageService) { }

  showSucess(message){
    this.messageService.add({severity:'success', summary: 'Success', detail: message});
  }

  showError(message){
    this.messageService.add({severity:'error', summary: 'Erro', detail: message});
  }
}