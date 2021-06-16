import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TryDrowComponent } from './try-drow.component';

describe('TryDrowComponent', () => {
  let component: TryDrowComponent;
  let fixture: ComponentFixture<TryDrowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TryDrowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TryDrowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
