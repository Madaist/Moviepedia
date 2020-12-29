import { Component, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MovieDTO } from '../../shared/models/movie-dto';
import { MovieService } from '../../shared/services/movie.service';
import { UpdateMovieDTO } from '../../shared/models/update-movie-dto';
import Swal from 'sweetalert2';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-edit-movie-modal',
  templateUrl: './edit-movie-modal.component.html',
  styleUrls: ['./edit-movie-modal.component.css']
})
export class EditMovieModalComponent {
  @ViewChild('editMovieModal', { static: false }) modal: ModalDirective;
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  editMovieForm: FormGroup;
  movie: MovieDTO = new MovieDTO();

  constructor(public fb: FormBuilder, private _movieService: MovieService) { }

  initialize(movieId: string): void {
    this.modal.show();
    this._movieService.getMovie(movieId)
      .subscribe((data: MovieDTO) => {
        this.movie = data;
        this.initializeForm(this.movie);
      },
        (error: Error) => {
          console.log('err', error);
        });
  }

  initializeForm(movie: MovieDTO) {
    this.editMovieForm = this.fb.group({
      title: [movie.title, Validators.required],
      picture: [movie.picture, Validators.required],
      storyLine: [movie.storyLine, Validators.required],
      releaseYear: [movie.releaseYear, Validators.required],
      category: [movie.category, Validators.required],
      boxOffice: [movie.boxOffice, Validators.required],
    });
  }

  editMovie() {
    const editedMovie = new UpdateMovieDTO(
      this.movie.id,
      this.editMovieForm.value.title,
      this.editMovieForm.value.picture,
      this.editMovieForm.value.storyLine,
      this.editMovieForm.value.releaseYear,
      this.editMovieForm.value.category,
      this.editMovieForm.value.boxOffice
    );

    this._movieService.updateMovie(editedMovie)
      .subscribe(() => {
        this.change.emit('updateMovie');
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
