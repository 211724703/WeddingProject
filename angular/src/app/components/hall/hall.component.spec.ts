import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HallComponent } from './hall.component';
// import {MatRadioModule} from '@angular/material/radio';

describe('HallComponent', () => {
  let component: HallComponent;
  let fixture: ComponentFixture<HallComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HallComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
