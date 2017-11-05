import { TestBed, inject } from '@angular/core/testing';

import { PingPongClientService } from './ping-pong-client.service';

describe('PingPongClientService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PingPongClientService]
    });
  });

  it('should be created', inject([PingPongClientService], (service: PingPongClientService) => {
    expect(service).toBeTruthy();
  }));
});
