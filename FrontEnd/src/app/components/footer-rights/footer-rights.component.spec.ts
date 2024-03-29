import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FooterRightsComponent } from './footer-rights.component';

describe('FooterRightsComponent', () => {
  let component: FooterRightsComponent;
  let fixture: ComponentFixture<FooterRightsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FooterRightsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FooterRightsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
