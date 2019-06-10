/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { FormCadastarComponent } from './formCadastar.component';

describe('FormCadastarComponent', () => {
  let component: FormCadastarComponent;
  let fixture: ComponentFixture<FormCadastarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormCadastarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormCadastarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
