import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrecentComponent } from './precent.component';

describe('PrecentComponent', () => {
  let component: PrecentComponent;
  let fixture: ComponentFixture<PrecentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrecentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrecentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});



