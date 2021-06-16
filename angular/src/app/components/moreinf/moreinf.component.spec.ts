import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MoreinfComponent } from './moreinf.component';

describe('MoreinfComponent', () => {
  let component: MoreinfComponent;
  let fixture: ComponentFixture<MoreinfComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MoreinfComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MoreinfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
