import { TestBed } from '@angular/core/testing';

import { RabbiService } from './rabbi.service';

describe('RabbiService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RabbiService = TestBed.get(RabbiService);
    expect(service).toBeTruthy();
  });
});
