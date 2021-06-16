import { TestBed } from '@angular/core/testing';

import { NewMemberServiceService } from './new-member-service.service';

describe('NewMemberServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NewMemberServiceService = TestBed.get(NewMemberServiceService);
    expect(service).toBeTruthy();
  });
});
