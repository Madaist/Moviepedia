import { Component, OnInit, ViewChild, Output, EventEmitter } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import Swal from 'sweetalert2';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { PostReviewDTO } from '../../shared/models/post-review-dto';
import { ReviewService } from '../../shared/services/review.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-add-review-modal',
  templateUrl: './add-review-modal.component.html',
  styleUrls: ['./add-review-modal.component.css']
})
export class AddReviewModalComponent {
  @ViewChild('reviewModal', { static: false }) modal: ModalDirective;
  addReviewForm: FormGroup;
  movieId: string;
  review: PostReviewDTO = new PostReviewDTO();
  @Output() change: EventEmitter<string> = new EventEmitter<string>();

  constructor(public fb: FormBuilder, private _reviewService: ReviewService) { }

  initialize(movieId: string): void {
    this.modal.show();
    this.initializeForm();
    this.movieId = movieId;
  }

  initializeForm() {
    this.addReviewForm = this.fb.group({
      content: [null, Validators.required],
    });
  }

  addReview() {
    const review = new PostReviewDTO(this.movieId, this.addReviewForm.value.content);
    this._reviewService.postReview(review).subscribe(() => {
      Swal.fire({
        title: 'Your review was successfully submitted.',
        text: 'Thank you for your contribution!',
        icon: 'success',
        width: '25vw',
        confirmButtonColor: '#b380ff',
      });
      this.change.emit('review');
      this.modal.hide();
    },
      (error: HttpErrorResponse) => {
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
