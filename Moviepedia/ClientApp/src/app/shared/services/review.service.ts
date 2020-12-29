import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PostReviewDTO } from '../models/post-review-dto';
import { UpdateReviewDTO } from '../models/update-review-dto';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {

  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44355/api/Review';

  postReview(review: PostReviewDTO) {
    return this.http.post(this.baseUrl, review, { headers: this.header });
  }

  getReviews() {
    return this.http.get(this.baseUrl, { headers: this.header });
  }

  deleteReview(reviewId: string) {
    return this.http.delete(this.baseUrl + '/' + reviewId, { headers: this.header });
  }

  updateReview(reviewDTO: UpdateReviewDTO) {
    return this.http.put(this.baseUrl, reviewDTO, { headers: this.header });
  }


}
