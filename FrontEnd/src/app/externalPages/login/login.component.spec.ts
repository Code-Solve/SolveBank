import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExternalLoginComponent } from './login.component';

describe('LoginComponent', () => {
  let component: ExternalLoginComponent;
  let fixture: ComponentFixture<ExternalLoginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ExternalLoginComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ExternalLoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
