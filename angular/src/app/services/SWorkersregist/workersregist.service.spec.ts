import { TestBed } from '@angular/core/testing';

import { WorkersregistService } from './workersregist.service';

describe('WorkersregistService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: WorkersregistService = TestBed.get(WorkersregistService);
    expect(service).toBeTruthy();
  });
});
