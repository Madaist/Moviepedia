import { Component, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActorDTO } from '../../shared/models/actor-dto';
import { ActorService } from '../../shared/services/actor.service';
import Swal from 'sweetalert2';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-edit-actor-modal',
  templateUrl: './edit-actor-modal.component.html',
  styleUrls: ['./edit-actor-modal.component.css']
})
export class EditActorModalComponent {
  @ViewChild('editActorModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  editActorForm: FormGroup;
  actor: ActorDTO = new ActorDTO();

  constructor(public fb: FormBuilder, private _actorService: ActorService) { }

  initialize(actorId: string): void {
    this.modal.show();
    this._actorService.getActor(actorId)
      .subscribe((data: ActorDTO) => {
        this.actor = data;
        console.log(this.actor);
        this.initializeForm(this.actor);
      },
        (error: Error) => {
          console.log('err', error);
        });
  }

  initializeForm(actor: ActorDTO) {
    this.editActorForm = this.fb.group({
      lastName: [actor.lastName, Validators.required],
      firstName: [actor.firstName, Validators.required],
      picture: [actor.picture, Validators.required],
      age: [actor.age, Validators.required],
    });
  }

  editActor() {
    const editedActor = new ActorDTO(
      this.actor.id,
      this.editActorForm.value.lastName,
      this.editActorForm.value.firstName,
      this.editActorForm.value.age,
      this.editActorForm.value.picture,
    );

    this._actorService.updateActor(editedActor)
      .subscribe(() => {
        this.change.emit('updateActor');
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
