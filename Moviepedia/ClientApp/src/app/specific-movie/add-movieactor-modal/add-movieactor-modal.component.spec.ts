import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddMovieactorModalComponent } from './add-movieactor-modal.component';

describe('AddMovieactorModalComponent', () => {
  let component: AddMovieactorModalComponent;
  let fixture: ComponentFixture<AddMovieactorModalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddMovieactorModalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddMovieactorModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
