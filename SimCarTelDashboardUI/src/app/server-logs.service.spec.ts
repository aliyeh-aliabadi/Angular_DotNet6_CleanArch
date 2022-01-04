import { TestBed } from '@angular/core/testing';

import { ServerLogsService } from './server-logs.service';

describe('ServerLogsService', () => {
  let service: ServerLogsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServerLogsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
