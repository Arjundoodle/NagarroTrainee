import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdmincarviewComponent } from './admincarview.component';

describe('AdmincarviewComponent', () => {
  let component: AdmincarviewComponent;
  let fixture: ComponentFixture<AdmincarviewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdmincarviewComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdmincarviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
