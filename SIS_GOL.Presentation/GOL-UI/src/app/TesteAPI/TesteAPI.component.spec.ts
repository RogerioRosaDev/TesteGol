/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TesteAPIComponent } from './TesteAPI.component';

describe('TesteAPIComponent', () => {
  let component: TesteAPIComponent;
  let fixture: ComponentFixture<TesteAPIComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TesteAPIComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TesteAPIComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
