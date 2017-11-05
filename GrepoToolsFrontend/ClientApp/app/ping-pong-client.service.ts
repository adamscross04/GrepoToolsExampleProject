import { Injectable } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

@Injectable()
export class PingPongClientService {

  constructor() {

    
  }

  hello(): string {
    return "hello world";
  }

}
