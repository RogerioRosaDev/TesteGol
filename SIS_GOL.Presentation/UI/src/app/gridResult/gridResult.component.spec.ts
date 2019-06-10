/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { GridResultComponent } from './gridResult.component';

describe('GridResultComponent', () => {
  let component: GridResultComponent;
  let fixture: ComponentFixture<GridResultComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GridResultComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GridResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
