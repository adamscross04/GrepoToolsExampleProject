import { Component, OnInit } from '@angular/core';
import { PingPongClientService } from '../../ping-pong-client.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss'],
  providers: [PingPongClientService]
})
export class MainComponent implements OnInit {

  constructor(private _pingPongClientService: PingPongClientService) {

  }

  ClickMe() {
    this.MyName = this._pingPongClientService.hello();
  }

  MyName: string = "----";

  ngOnInit() {
  }

}
