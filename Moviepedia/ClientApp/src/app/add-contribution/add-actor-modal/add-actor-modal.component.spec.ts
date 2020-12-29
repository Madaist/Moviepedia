import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddActorModalComponent } from './add-actor-modal.component';

describe('AddActorModalComponent', () => {
  let component: AddActorModalComponent;
  let fixture: ComponentFixture<AddActorModalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddActorModalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddActorModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
