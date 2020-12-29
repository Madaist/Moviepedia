import { Component, ViewChild, Output, EventEmitter } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { PostMovieDTO } from '../../shared/models/post-movie-dto';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MovieService } from '../../shared/services/movie.service';
import Swal from 'sweetalert2';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-add-movie-modal',
  templateUrl: './add-movie-modal.component.html',
  styleUrls: ['./add-movie-modal.component.css']
})
export class AddMovieModalComponent {
  @ViewChild('addMovieModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  addMovieForm: FormGroup;
  movie: PostMovieDTO = new PostMovieDTO();

  constructor(public fb: FormBuilder, private _movieService: MovieService) { }

  initialize(): void {
    this.modal.show();
    this.initializeForm();
  }

  initializeForm() {
    this.addMovieForm = this.fb.group({
      title: [null, Validators.required],
      picture: [null, Validators.required],
      storyLine: [null, Validators.required],
      releaseYear: [null, Validators.required],
      category: [null, Validators.required],
      boxOffice: [null, Validators.required],
    });
  }

  createMovie() {
    const createdMovie = new PostMovieDTO(
      this.movie.id,
      this.addMovieForm.value.title,
      this.addMovieForm.value.picture,
      this.addMovieForm.value.storyLine,
      this.addMovieForm.value.releaseYear,
      this.addMovieForm.value.category,
      this.addMovieForm.value.boxOffice
    );

    this._movieService.createMovie(createdMovie)
      .subscribe(() => {
        this.change.emit('createMovie');
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
