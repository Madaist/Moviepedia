import { Component, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActorDTO } from '../../shared/models/actor-dto';
import { ActorService } from '../../shared/services/actor.service';
import Swal from 'sweetalert2';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-add-actor-modal',
  templateUrl: './add-actor-modal.component.html',
  styleUrls: ['./add-actor-modal.component.css']
})
export class AddActorModalComponent {

  @ViewChild('addActorModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  addActorForm: FormGroup;
  actor: ActorDTO = new ActorDTO();

  constructor(public fb: FormBuilder, private _actorService: ActorService) { }

  initialize(): void {
    this.modal.show();
    this.initializeForm();
  }

  initializeForm() {
    this.addActorForm = this.fb.group({
      lastName: [null, Validators.required],
      firstName: [null, Validators.required],
      age: [null, Validators.required],
      picture: [null, Validators.required],
    });
  }

  addActor() {
    const createdActor = new ActorDTO(
      this.addActorForm.value.lastName,
      this.addActorForm.value.firstName,
      this.addActorForm.value.age,
      this.addActorForm.value.picture
    );

    this._actorService.addActor(createdActor)
      .subscribe(() => {
        this.change.emit('createActor');
        this.modal.hide();
        Swal.fire({
          title: 'Changes have been submitted.',
          text: 'Thank you for your contribution!',
          icon: 'success',
          width: '25vw',
          confirmButtonColor: '#b380ff',
        });
      },
        (error: HttpErrorResponse) => {
          console.log('err', error);
          Swal.fire({
            icon: 'error',
            title: 'Something went wrong',
            text: error.error,
            confirmButtonColor: '#b380ff',
            width: '30vw',
          });
        });
  }

}
