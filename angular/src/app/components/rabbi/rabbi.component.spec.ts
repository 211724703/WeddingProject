import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RabbiComponent } from './rabbi.component';

describe('RabbiComponent', () => {
  let component: RabbiComponent;
  let fixture: ComponentFixture<RabbiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RabbiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RabbiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
