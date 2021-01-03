import { HttpErrorResponse } from '@angular/common/http';
import { Component, EventEmitter, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';
import { ActorDTO } from '../../shared/models/actor-dto';
import { MovieActorsDTO } from '../../shared/models/movie-actors-dto';
import { ActorService } from '../../shared/services/actor.service';
import { MovieActorsService } from '../../shared/services/movie-actors.service';

@Component({
  selector: 'app-add-movieactor-modal',
  templateUrl: './add-movieactor-modal.component.html',
  styleUrls: ['./add-movieactor-modal.component.css']
})
export class AddMovieactorModalComponent {

  @ViewChild('addMovieactorModal', { static: false }) modal: ModalDirective;
  addMovieActorForm: FormGroup;
  movieId: string;
  actors: Array<ActorDTO> = new Array<ActorDTO>();
  selectedActor: string;

  @Output() change: EventEmitter<string> = new EventEmitter<string>();
  constructor(public fb: FormBuilder,
    private _movieActorsService: MovieActorsService,
    private _actorService: ActorService) { }

  initialize(movieId: string): void {
    this.getActors();
    this.modal.show();
    this.initializeForm();
    this.movieId = movieId;
  }

  getActors() {
    this._actorService.getActors().subscribe((data: ActorDTO[]) => {
      this.actors = data;
    })
  }

  initializeForm() {
    this.addMovieActorForm = this.fb.group({
      actorId: [null, Validators.required],
    });
  }

  addMovieActor() {
    const movieActor = new MovieActorsDTO(this.movieId, this.selectedActor);
    this._movieActorsService.addMovieActors(movieActor).subscribe(() => {
      Swal.fire({
        title: 'Your actor was successfully added.',
        text: 'Thank you for your contribution!',
        icon: 'success',
        width: '25vw',
        confirmButtonColor: '#b380ff',
      });
      this.change.emit('movieActor');
      this.modal.hide();
    },
      (error: HttpErrorResponse) => {
        Swal.fire({
          icon: 'error',
          title: error.error,
          confirmButtonColor: '#b380ff',
          width: '30vw',
        });
      });
  }

}
