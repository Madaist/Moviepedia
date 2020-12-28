import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import Swal from 'sweetalert2';
import { MovieService } from '../shared/services/movie.service';
import { MovieDTO } from '../shared/models/movie-dto';
import { AddReviewModalComponent } from './add-review-modal/add-review-modal.component';
import { EditMovieModalComponent } from './edit-movie-modal/edit-movie-modal.component';


@Component({
  selector: 'app-specific-movie',
  templateUrl: './specific-movie.component.html',
  styleUrls: ['./specific-movie.component.css']
})
export class SpecificMovieComponent implements OnInit {
  movie: MovieDTO = new MovieDTO();

  @ViewChild('reviewModal', { static: false }) reviewModal: AddReviewModalComponent;
  @ViewChild('editMovieModal', { static: false }) editMovieModal: EditMovieModalComponent;

  constructor(private route: ActivatedRoute,
    private _movieService: MovieService) { }

  ngOnInit() {
    this.getMovie();
  }

  deleteMovie() {
    Swal.fire({
      title: 'Are you sure?',
      text: "You won't be able to revert this!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#cc99ff',
      cancelButtonColor: '#a64dff',
      confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
      if (result.isConfirmed) {
        this._movieService.deleteMovie(this.movie.id).subscribe(() => {
          Swal.fire({
            title: 'Deleted!',
            text: 'Movie has been deleted.',
            icon: 'success',
            confirmButtonColor: '#a64dff'
          }
          )
        });
      }
    })
  }

  showReviewModal(): void {
    this.reviewModal.initialize(this.movie.id);
  }

  showEditMovieModal(): void {
    this.editMovieModal.initialize(this.movie.id);
  }

  getMovie() {
    this.route.params.subscribe(params => {
      this._movieService.getMovie(params['movieId']).subscribe((data: MovieDTO) => {
        this.movie = data;
        console.log(this.movie);
      })
    });
  }

  onEditFinished(event: string) {
    this.getMovie();
  }

}
